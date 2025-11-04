using System;
using System.Drawing;
using System.Windows.Forms;

namespace raketaaaaa
{
    public partial class Form1 : Form
    {
        int raketaRychlost = 10;
        int meteoritRychlost = 10;
        int skore = 0;
        int zivoty = 3;
        int palivo = 100;

        Random rnd = new Random();

        bool pohybVlevo = false;
        bool pohybVpravo = false;

        PictureBox[] meteory;
        PictureBox[] srdce;
        Timer Casovac = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Zachycení kláves
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;

            // Inicializace rakety
            boxRaketa.Left = hraciPlocha.Width / 2 - boxRaketa.Width / 2;
            boxRaketa.Top = hraciPlocha.Height - boxRaketa.Height - 10;

            // Inicializace meteoritu
            PictureBox meteor1 = boxMeteorit; // z designeru
            PictureBox meteor2 = new PictureBox(); // druhý meteorit
            meteor2.Size = meteor1.Size;
            meteor2.SizeMode = PictureBoxSizeMode.Zoom;
            meteor2.Image = meteor1.Image;
            hraciPlocha.Controls.Add(meteor2);

            meteory = new PictureBox[] { meteor1, meteor2 };

            foreach (var meteor in meteory)
                ResetMeteor(meteor);

            // Inicializace srdcí (všimni si, že poslední se jmenuje boxzivot3 s malým z)
            srdce = new PictureBox[] { boxZivot1, boxZivot2, boxzivot3 };

            // Timer
            Casovac.Interval = 50;
            Casovac.Tick += GameLoop;
            Casovac.Start();
        }

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

        private void GameLoop(object sender, EventArgs e)
        {
            // Pohyb rakety
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

            palivo = Math.Max(palivo, 0);

            // Pohyb meteorů
            for (int i = 0; i < meteory.Length; i++)
                MoveMeteor(meteory[i]);

            // Aktualizace srdcí
            for (int i = 0; i < srdce.Length; i++)
                srdce[i].Visible = (i < zivoty);

            // Aktualizace UI
            BoxSkore.Text = skore.ToString();
            BoxPalivo.Text = palivo.ToString() + "%";
        }

        private void MoveMeteor(PictureBox meteor)
        {
            meteor.Top += meteoritRychlost;

            // Kolize s raketou
            if (meteor.Bounds.IntersectsWith(boxRaketa.Bounds))
            {
                zivoty--;
                palivo = 100;
                ResetMeteor(meteor);

                if (zivoty <= 0)
                {
                    Casovac.Stop();
                    MessageBox.Show("Konec hry! Tvé skóre: " + skore);
                    this.Close();
                }
            }

            // Meteor spadl mimo obrazovku
            if (meteor.Top > hraciPlocha.Height)
            {
                skore++;
                ResetMeteor(meteor);
            }
        }

        private void ResetMeteor(PictureBox meteor)
        {
            meteor.Left = rnd.Next(0, hraciPlocha.Width - meteor.Width);
            meteor.Top = -meteor.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // sem můžeš doplnit logiku po načtení formuláře
        }

        private void hraciPlocha_Enter(object sender, EventArgs e)
        {
        }
    }
}
