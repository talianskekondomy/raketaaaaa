using System.Windows.Forms;

namespace raketaaaaa
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNadpisRaketa = new System.Windows.Forms.Label();
            this.hraciPlocha = new System.Windows.Forms.GroupBox();
            this.boxMeteorit = new System.Windows.Forms.PictureBox();
            this.boxRaketa = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtZivoty = new System.Windows.Forms.Label();
            this.txtPalivo = new System.Windows.Forms.Label();
            this.BoxSkore = new System.Windows.Forms.TextBox();
            this.BoxPalivo = new System.Windows.Forms.TextBox();
            this.boxZivot1 = new System.Windows.Forms.PictureBox();
            this.boxZivot2 = new System.Windows.Forms.PictureBox();
            this.boxZivot3 = new System.Windows.Forms.PictureBox();

            // === OVLÁDACÍ PANEL ===
            this.groupOvládání = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.trackBarRychlost = new System.Windows.Forms.TrackBar();
            this.progressBarPalivo = new System.Windows.Forms.ProgressBar();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelRychlost = new System.Windows.Forms.Label();

            this.hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxMeteorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRaketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRychlost)).BeginInit();
            this.groupOvládání.SuspendLayout();
            this.SuspendLayout();

            // txtNadpisRaketa
            this.txtNadpisRaketa.AutoSize = true;
            this.txtNadpisRaketa.Location = new System.Drawing.Point(490, 15);
            this.txtNadpisRaketa.Name = "txtNadpisRaketa";
            this.txtNadpisRaketa.Size = new System.Drawing.Size(111, 22);
            this.txtNadpisRaketa.TabIndex = 0;
            this.txtNadpisRaketa.Text = "Hra Raketa";
            this.txtNadpisRaketa.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            // hraciPlocha
            this.hraciPlocha.BackColor = System.Drawing.SystemColors.Desktop;
            this.hraciPlocha.Controls.Add(this.boxMeteorit);
            this.hraciPlocha.Controls.Add(this.boxRaketa);
            this.hraciPlocha.Location = new System.Drawing.Point(-5, 50);
            this.hraciPlocha.Name = "hraciPlocha";
            this.hraciPlocha.Size = new System.Drawing.Size(1107, 523);
            this.hraciPlocha.TabIndex = 1;
            this.hraciPlocha.TabStop = false;

            // boxMeteorit
            this.boxMeteorit.Image = global::raketaaaaa.Properties.Resources.Meteorit;
            this.boxMeteorit.Location = new System.Drawing.Point(48, 27);
            this.boxMeteorit.Name = "boxMeteorit";
            this.boxMeteorit.Size = new System.Drawing.Size(46, 54);
            this.boxMeteorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxMeteorit.TabIndex = 1;
            this.boxMeteorit.TabStop = false;

            // boxRaketa 
            this.boxRaketa.Image = global::raketaaaaa.Properties.Resources.raketa_png_vektorovy_obrazek_ilustra_ni_klipart_raketa_zdarma_ke_sta_eni_doprava_vektor_do_vasich_dokument_286;
            this.boxRaketa.Location = new System.Drawing.Point(528, 433);
            this.boxRaketa.Name = "boxRaketa";
            this.boxRaketa.Size = new System.Drawing.Size(57, 63);
            this.boxRaketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxRaketa.TabIndex = 0;
            this.boxRaketa.TabStop = false;

            // txtScore
            this.txtScore.AutoSize = true;
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtScore.Location = new System.Drawing.Point(20, 585);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(68, 22);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Skóre:";

            // txtZivoty
            this.txtZivoty.AutoSize = true;
            this.txtZivoty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtZivoty.Location = new System.Drawing.Point(510, 585);
            this.txtZivoty.Name = "txtZivoty";
            this.txtZivoty.Size = new System.Drawing.Size(70, 22);
            this.txtZivoty.TabIndex = 3;
            this.txtZivoty.Text = "Životy:";

            // txtPalivo
            this.txtPalivo.AutoSize = true;
            this.txtPalivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPalivo.Location = new System.Drawing.Point(923, 585);
            this.txtPalivo.Name = "txtPalivo";
            this.txtPalivo.Size = new System.Drawing.Size(71, 22);
            this.txtPalivo.TabIndex = 4;
            this.txtPalivo.Text = "Palivo:";

            // BoxSkore
            this.BoxSkore.Location = new System.Drawing.Point(90, 580);
            this.BoxSkore.Name = "BoxSkore";
            this.BoxSkore.Size = new System.Drawing.Size(60, 28);
            this.BoxSkore.TabIndex = 5;

            // BoxPalivo
            this.BoxPalivo.Location = new System.Drawing.Point(1000, 580);
            this.BoxPalivo.Name = "BoxPalivo";
            this.BoxPalivo.Size = new System.Drawing.Size(60, 28);
            this.BoxPalivo.TabIndex = 6;

            // boxZivot1
            this.boxZivot1.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxZivot1.Location = new System.Drawing.Point(585, 585);
            this.boxZivot1.Name = "boxZivot1";
            this.boxZivot1.Size = new System.Drawing.Size(26, 25);
            this.boxZivot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxZivot1.TabIndex = 7;
            this.boxZivot1.TabStop = false;

            // boxZivot2
            this.boxZivot2.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxZivot2.Location = new System.Drawing.Point(617, 585);
            this.boxZivot2.Name = "boxZivot2";
            this.boxZivot2.Size = new System.Drawing.Size(26, 25);
            this.boxZivot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxZivot2.TabIndex = 8;
            this.boxZivot2.TabStop = false;

           // boxZivot3
            this.boxZivot3.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxZivot3.Location = new System.Drawing.Point(649, 585);
            this.boxZivot3.Name = "boxZivot3";
            this.boxZivot3.Size = new System.Drawing.Size(26, 25);
            this.boxZivot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxZivot3.TabIndex = 9;
            this.boxZivot3.TabStop = false;

            // groupOvládání
            this.groupOvládání.Controls.Add(this.buttonStart);
            this.groupOvládání.Controls.Add(this.buttonStop);
            this.groupOvládání.Controls.Add(this.buttonReset);
            this.groupOvládání.Controls.Add(this.trackBarRychlost);
            this.groupOvládání.Controls.Add(this.progressBarPalivo);
            this.groupOvládání.Controls.Add(this.labelInfo);
            this.groupOvládání.Controls.Add(this.labelRychlost);
            this.groupOvládání.Location = new System.Drawing.Point(12, 625);
            this.groupOvládání.Name = "groupOvládání";
            this.groupOvládání.Size = new System.Drawing.Size(1070, 120);
            this.groupOvládání.TabIndex = 10;
            this.groupOvládání.TabStop = false;
            this.groupOvládání.Text = "Ovládání";
 
            // buttonStart
            this.buttonStart.Text = "Start";
            this.buttonStart.Location = new System.Drawing.Point(20, 30);
            this.buttonStart.Size = new System.Drawing.Size(80, 30);
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);

            // buttonStop
            this.buttonStop.Text = "Stop";
            this.buttonStop.Location = new System.Drawing.Point(110, 30);
            this.buttonStop.Size = new System.Drawing.Size(80, 30);
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);

            // buttonReset
            this.buttonReset.Text = "Reset";
            this.buttonReset.Location = new System.Drawing.Point(200, 30);
            this.buttonReset.Size = new System.Drawing.Size(80, 30);
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);

            // trackBarRychlost
            this.trackBarRychlost.Location = new System.Drawing.Point(320, 30);
            this.trackBarRychlost.Maximum = 20;
            this.trackBarRychlost.Minimum = 5;
            this.trackBarRychlost.Value = 10;
            this.trackBarRychlost.TickFrequency = 1;
            this.trackBarRychlost.Size = new System.Drawing.Size(200, 45);
            this.trackBarRychlost.Scroll += new System.EventHandler(this.trackBarRychlost_Scroll);
            trackBarRychlost.TabStop = false;

            // labelRychlost
            this.labelRychlost.Text = "Rychlost: 10";
            this.labelRychlost.Location = new System.Drawing.Point(530, 35);

            // progressBarPalivo
            this.progressBarPalivo.Location = new System.Drawing.Point(650, 35);
            this.progressBarPalivo.Maximum = 100;
            this.progressBarPalivo.Size = new System.Drawing.Size(200, 25);
 
            // labelInfo
            this.labelInfo.Location = new System.Drawing.Point(870, 35);
            this.labelInfo.Size = new System.Drawing.Size(180, 40);
            this.labelInfo.Text = "Skóre: 0 | Životy: 3 | Palivo: 100%";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.groupOvládání);
            this.Controls.Add(this.boxZivot3);
            this.Controls.Add(this.boxZivot2);
            this.Controls.Add(this.boxZivot1);
            this.Controls.Add(this.BoxPalivo);
            this.Controls.Add(this.BoxSkore);
            this.Controls.Add(this.txtPalivo);
            this.Controls.Add(this.txtZivoty);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.hraciPlocha);
            this.Controls.Add(this.txtNadpisRaketa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hra raketa";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxMeteorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRaketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRychlost)).EndInit();
            this.groupOvládání.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label txtNadpisRaketa;
        private System.Windows.Forms.GroupBox hraciPlocha;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtZivoty;
        private System.Windows.Forms.Label txtPalivo;
        private System.Windows.Forms.TextBox BoxSkore;
        private System.Windows.Forms.PictureBox boxRaketa;
        private System.Windows.Forms.TextBox BoxPalivo;
        private System.Windows.Forms.PictureBox boxMeteorit;
        private System.Windows.Forms.PictureBox boxZivot1;
        private System.Windows.Forms.PictureBox boxZivot2;
        private System.Windows.Forms.PictureBox boxZivot3;

        // nové ovládací prvky
        private System.Windows.Forms.GroupBox groupOvládání;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TrackBar trackBarRychlost;
        private System.Windows.Forms.ProgressBar progressBarPalivo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelRychlost;
    }
}
