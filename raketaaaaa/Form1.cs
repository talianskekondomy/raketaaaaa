using System;
using System.Drawing;
using System.Windows.Forms;

namespace raketaaaaa
{
    public partial class Form1 : Form
    {
        // --- ZÁKLADNÍ PROMĚNNÉ ---
        int raketaRychlost = 10;   // rychlost pohybu rakety
        int meteoritRychlost = 10; // rychlost meteoritu
        int skore = 0;             // skóre hráče
        int zivoty = 3;            // počet životů
        int palivo = 100;          // množství paliva

        Random rnd = new Random(); // náhodné pozice meteorů
        bool pohybVlevo = false;   // jestli se raketa právě pohybuje vlevo
        bool pohybVpravo = false;  // jestli se raketa právě pohybuje vpravo

        PictureBox[] meteory;      // pole pro meteory
        PictureBox[] srdce;        // pole pro ikonky životů
        Timer Casovac = new Timer(); // hlavní časovač hry

        public Form1()
        {
            InitializeComponent();

            // Umožní zachytit klávesy i když má fokus jiný prvek (např. tlačítko)
            this.KeyPreview = true;
            this.ActiveControl = null; // zruší fokus z trackbaru, aby šipky hned fungovaly

            // Události pro klávesy
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Umístím raketu na střed hrací plochy
            boxRaketa.Left = hraciPlocha.Width / 2 - boxRaketa.Width / 2;
            boxRaketa.Top = hraciPlocha.Height - boxRaketa.Height - 10;

            // --- METEORITY ---
            // první meteorit je z Designeru
            PictureBox meteor1 = boxMeteorit;
            // druhý vytvořím dynamicky
            PictureBox meteor2 = new PictureBox();
            meteor2.Size = meteor1.Size;
            meteor2.SizeMode = PictureBoxSizeMode.StretchImage;
            meteor2.Image = meteor1.Image;
            hraciPlocha.Controls.Add(meteor2);

            // uložím meteory do pole a nastavím jejich pozici
            meteory = new PictureBox[] { meteor1, meteor2 };
            foreach (var m in meteory)
                ResetMeteor(m);

            // --- SRDCE (ŽIVOTY) ---
            srdce = new PictureBox[] { boxZivot1, boxZivot2, boxZivot3 };

            // --- ČASOVAČ ---
            Casovac.Interval = 50; // obnovování hry každých 50 ms
            Casovac.Tick += GameLoop; // hlavní herní smyčka

            // Aktualizuju prvky hned po spuštění
            AktualizujUI();
        }

        // --- OVLÁDÁNÍ KLÁVESAMI ---
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pohybVlevo = true;
            if (e.KeyCode == Keys.Right) pohybVpravo = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) pohybVlevo = false;
            if (e.KeyCode == Keys.Right) pohybVpravo = false;
        }

        // --- HLAVNÍ SMYČKA HRY ---
        private void GameLoop(object sender, EventArgs e)
        {
            // Pohyb rakety – jen pokud máme palivo
            if (pohybVlevo && boxRaketa.Left > 0 && palivo > 0)
            {
                boxRaketa.Left -= raketaRychlost;
                palivo--;
            }
            if (pohybVpravo && boxRaketa.Right < hraciPlocha.Width && palivo > 0)
            {
                boxRaketa.Left += raketaRychlost;
                palivo--;
            }

            palivo = Math.Max(palivo, 0); // aby palivo nešlo do mínusu

            // Pohyb meteorů
            foreach (var meteor in meteory)
                MoveMeteor(meteor);

            // Aktualizace viditelných srdcí podle životů
            for (int i = 0; i < srdce.Length; i++)
                srdce[i].Visible = (i < zivoty);

            AktualizujUI();
        }

        // --- POHYB METEORITU ---
        private void MoveMeteor(PictureBox meteor)
        {
            meteor.Top += meteoritRychlost;

            // Kolize s raketou → ztráta života
            if (meteor.Bounds.IntersectsWith(boxRaketa.Bounds))
            {
                zivoty--;
                palivo = 100; // doplním palivo po zásahu
                ResetMeteor(meteor);

                if (zivoty <= 0)
                {
                    Casovac.Stop();
                    hraciPlocha.BackColor = Color.DarkRed;
                    MessageBox.Show($"Konec hry!\nTvé skóre: {skore}", "Game Over");
                    return;
                }
            }

            // Pokud meteorit spadne mimo okno -> přičti skóre
            if (meteor.Top > hraciPlocha.Height)
            {
                skore++;
                ResetMeteor(meteor);
            }
        }

        // --- VRÁCENÍ METEORITU NAHORU ---
        private void ResetMeteor(PictureBox meteor)
        {
            meteor.Left = rnd.Next(0, hraciPlocha.Width - meteor.Width);
            meteor.Top = -meteor.Height;
        }

        // --- AKTUALIZACE TEXTŮ A PRVKŮ ---
        private void AktualizujUI()
        {
            BoxSkore.Text = skore.ToString();
            BoxPalivo.Text = $"{palivo}%";

            progressBarPalivo.Value = Math.Max(0, Math.Min(palivo, 100));
            labelInfo.Text = $"Skóre: {skore} | Životy: {zivoty} | Palivo: {palivo}%";
            labelRychlost.Text = $"Rychlost: {raketaRychlost}";
        }

        // --- TLAČÍTKA ---
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Casovac.Start();
            hraciPlocha.BackColor = Color.Black;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Casovac.Stop();
            hraciPlocha.BackColor = Color.DarkSlateGray;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Casovac.Stop();
            skore = 0;
            zivoty = 3;
            palivo = 100;
            raketaRychlost = 10;
            meteoritRychlost = 10;

            foreach (var m in meteory)
                ResetMeteor(m);

            // raketu vrátím na střed
            boxRaketa.Left = hraciPlocha.Width / 2 - boxRaketa.Width / 2;

            AktualizujUI();
            hraciPlocha.BackColor = Color.Black;
        }

        // --- SLIDER NA RYCHLOST ---
        private void trackBarRychlost_Scroll(object sender, EventArgs e)
        {
            raketaRychlost = trackBarRychlost.Value;
            labelRychlost.Text = $"Rychlost: {raketaRychlost}";

            // Po posunu slideru zruším fokus → šipky zase ovládají raketu
            this.ActiveControl = null;
        }

        // --- OSTATNÍ METODY (nepoužité, ale nechávám pro přehled) ---
        private void Form1_Load(object sender, EventArgs e) { }
        private void hraciPlocha_Enter(object sender, EventArgs e) { }
    }
}
