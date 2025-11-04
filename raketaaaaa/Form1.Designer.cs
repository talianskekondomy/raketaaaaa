namespace raketaaaaa
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNadpisRaketa = new System.Windows.Forms.Label();
            this.hraciPlocha = new System.Windows.Forms.GroupBox();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtZivoty = new System.Windows.Forms.Label();
            this.txtPalivo = new System.Windows.Forms.Label();
            this.BoxSkore = new System.Windows.Forms.TextBox();
            this.BoxPalivo = new System.Windows.Forms.TextBox();
            this.boxZivot1 = new System.Windows.Forms.PictureBox();
            this.boxMeteorit = new System.Windows.Forms.PictureBox();
            this.boxRaketa = new System.Windows.Forms.PictureBox();
            this.boxZivot2 = new System.Windows.Forms.PictureBox();
            this.boxzivot3 = new System.Windows.Forms.PictureBox();
            this.hraciPlocha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMeteorit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRaketa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxzivot3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNadpisRaketa
            // 
            this.txtNadpisRaketa.AutoSize = true;
            this.txtNadpisRaketa.Location = new System.Drawing.Point(491, 17);
            this.txtNadpisRaketa.Name = "txtNadpisRaketa";
            this.txtNadpisRaketa.Size = new System.Drawing.Size(111, 22);
            this.txtNadpisRaketa.TabIndex = 0;
            this.txtNadpisRaketa.Text = "Hra Raketa";
            this.txtNadpisRaketa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // hraciPlocha
            // 
            this.hraciPlocha.BackColor = System.Drawing.SystemColors.Desktop;
            this.hraciPlocha.Controls.Add(this.boxMeteorit);
            this.hraciPlocha.Controls.Add(this.boxRaketa);
            this.hraciPlocha.Location = new System.Drawing.Point(-5, 51);
            this.hraciPlocha.Name = "hraciPlocha";
            this.hraciPlocha.Size = new System.Drawing.Size(1107, 523);
            this.hraciPlocha.TabIndex = 1;
            this.hraciPlocha.TabStop = false;
            this.hraciPlocha.Enter += new System.EventHandler(this.hraciPlocha_Enter);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtScore.Location = new System.Drawing.Point(21, 588);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(68, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Skóre:";
            // 
            // txtZivoty
            // 
            this.txtZivoty.AutoSize = true;
            this.txtZivoty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtZivoty.Location = new System.Drawing.Point(510, 588);
            this.txtZivoty.Name = "txtZivoty";
            this.txtZivoty.Size = new System.Drawing.Size(70, 22);
            this.txtZivoty.TabIndex = 2;
            this.txtZivoty.Text = "Životy:";
            // 
            // txtPalivo
            // 
            this.txtPalivo.AutoSize = true;
            this.txtPalivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPalivo.Location = new System.Drawing.Point(923, 588);
            this.txtPalivo.Name = "txtPalivo";
            this.txtPalivo.Size = new System.Drawing.Size(71, 22);
            this.txtPalivo.TabIndex = 3;
            this.txtPalivo.Text = "Palivo:";
            // 
            // BoxSkore
            // 
            this.BoxSkore.Location = new System.Drawing.Point(95, 583);
            this.BoxSkore.Name = "BoxSkore";
            this.BoxSkore.Size = new System.Drawing.Size(61, 28);
            this.BoxSkore.TabIndex = 4;
            // 
            // BoxPalivo
            // 
            this.BoxPalivo.Location = new System.Drawing.Point(1000, 584);
            this.BoxPalivo.Name = "BoxPalivo";
            this.BoxPalivo.Size = new System.Drawing.Size(62, 28);
            this.BoxPalivo.TabIndex = 5;
            // 
            // boxZivot1
            // 
            this.boxZivot1.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxZivot1.Location = new System.Drawing.Point(586, 588);
            this.boxZivot1.Name = "boxZivot1";
            this.boxZivot1.Size = new System.Drawing.Size(26, 25);
            this.boxZivot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxZivot1.TabIndex = 6;
            this.boxZivot1.TabStop = false;
            // 
            // boxMeteorit
            // 
            this.boxMeteorit.Image = global::raketaaaaa.Properties.Resources.Meteorit;
            this.boxMeteorit.Location = new System.Drawing.Point(48, 27);
            this.boxMeteorit.Name = "boxMeteorit";
            this.boxMeteorit.Size = new System.Drawing.Size(46, 54);
            this.boxMeteorit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxMeteorit.TabIndex = 1;
            this.boxMeteorit.TabStop = false;
            // 
            // boxRaketa
            // 
            this.boxRaketa.Image = global::raketaaaaa.Properties.Resources.raketa_png_vektorovy_obrazek_ilustra_ni_klipart_raketa_zdarma_ke_sta_eni_doprava_vektor_do_vasich_dokument_286;
            this.boxRaketa.InitialImage = ((System.Drawing.Image)(resources.GetObject("boxRaketa.InitialImage")));
            this.boxRaketa.Location = new System.Drawing.Point(528, 433);
            this.boxRaketa.Name = "boxRaketa";
            this.boxRaketa.Size = new System.Drawing.Size(57, 63);
            this.boxRaketa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxRaketa.TabIndex = 0;
            this.boxRaketa.TabStop = false;
            // 
            // boxZivot2
            // 
            this.boxZivot2.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxZivot2.Location = new System.Drawing.Point(618, 588);
            this.boxZivot2.Name = "boxZivot2";
            this.boxZivot2.Size = new System.Drawing.Size(26, 25);
            this.boxZivot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxZivot2.TabIndex = 7;
            this.boxZivot2.TabStop = false;
            // 
            // boxzivot3
            // 
            this.boxzivot3.Image = global::raketaaaaa.Properties.Resources.valentine_heart_icon_6;
            this.boxzivot3.Location = new System.Drawing.Point(650, 588);
            this.boxzivot3.Name = "boxzivot3";
            this.boxzivot3.Size = new System.Drawing.Size(26, 25);
            this.boxzivot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxzivot3.TabIndex = 8;
            this.boxzivot3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.boxzivot3);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Hra raketa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.hraciPlocha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxMeteorit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxRaketa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxZivot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxzivot3)).EndInit();
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
        private System.Windows.Forms.PictureBox boxzivot3;
    }
}

