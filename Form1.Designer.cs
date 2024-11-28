namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.KullaniciArabasi = new System.Windows.Forms.PictureBox();
            this.Araba1 = new System.Windows.Forms.PictureBox();
            this.Araba2 = new System.Windows.Forms.PictureBox();
            this.Araba3 = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.oyunTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciArabasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba3)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciArabasi
            // 
            this.KullaniciArabasi.Image = ((System.Drawing.Image)(resources.GetObject("KullaniciArabasi.Image")));
            this.KullaniciArabasi.Location = new System.Drawing.Point(166, 339);
            this.KullaniciArabasi.Name = "KullaniciArabasi";
            this.KullaniciArabasi.Size = new System.Drawing.Size(50, 100);
            this.KullaniciArabasi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KullaniciArabasi.TabIndex = 0;
            this.KullaniciArabasi.TabStop = false;
            // 
            // Araba1
            // 
            this.Araba1.Image = ((System.Drawing.Image)(resources.GetObject("Araba1.Image")));
            this.Araba1.Location = new System.Drawing.Point(312, 260);
            this.Araba1.Name = "Araba1";
            this.Araba1.Size = new System.Drawing.Size(60, 100);
            this.Araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Araba1.TabIndex = 1;
            this.Araba1.TabStop = false;
            // 
            // Araba2
            // 
            this.Araba2.Image = ((System.Drawing.Image)(resources.GetObject("Araba2.Image")));
            this.Araba2.Location = new System.Drawing.Point(228, 27);
            this.Araba2.Name = "Araba2";
            this.Araba2.Size = new System.Drawing.Size(45, 100);
            this.Araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Araba2.TabIndex = 2;
            this.Araba2.TabStop = false;
            // 
            // Araba3
            // 
            this.Araba3.Image = ((System.Drawing.Image)(resources.GetObject("Araba3.Image")));
            this.Araba3.Location = new System.Drawing.Point(12, 122);
            this.Araba3.Name = "Araba3";
            this.Araba3.Size = new System.Drawing.Size(50, 100);
            this.Araba3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Araba3.TabIndex = 3;
            this.Araba3.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(12, 9);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(75, 24);
            this.lblSkor.TabIndex = 4;
            this.lblSkor.Text = "Skor: 0";
            // 
            // oyunTimer
            // 
            this.oyunTimer.Interval = 20;
            this.oyunTimer.Tick += new System.EventHandler(this.oyunTimer_Tick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.Araba3);
            this.Controls.Add(this.Araba2);
            this.Controls.Add(this.Araba1);
            this.Controls.Add(this.KullaniciArabasi);
            this.Name = "Form1";
            this.Text = "Araba Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciArabasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Araba3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KullaniciArabasi;
        private System.Windows.Forms.PictureBox Araba1;
        private System.Windows.Forms.PictureBox Araba2;
        private System.Windows.Forms.PictureBox Araba3;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer oyunTimer;
    }
}
