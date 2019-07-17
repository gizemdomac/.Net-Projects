namespace banka_personel
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uye_adi = new System.Windows.Forms.Label();
            this.uye_numarasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uye_sifre = new System.Windows.Forms.TextBox();
            this.giris = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BANKA PERSONEL TAKİP";
            // 
            // uye_adi
            // 
            this.uye_adi.AutoSize = true;
            this.uye_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uye_adi.Location = new System.Drawing.Point(214, 98);
            this.uye_adi.Name = "uye_adi";
            this.uye_adi.Size = new System.Drawing.Size(139, 25);
            this.uye_adi.TabIndex = 1;
            this.uye_adi.Text = "TC Numarası :";
            // 
            // uye_numarasi
            // 
            this.uye_numarasi.Location = new System.Drawing.Point(359, 104);
            this.uye_numarasi.MaxLength = 11;
            this.uye_numarasi.Name = "uye_numarasi";
            this.uye_numarasi.Size = new System.Drawing.Size(258, 20);
            this.uye_numarasi.TabIndex = 2;
            this.uye_numarasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uye_numarasi_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(290, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // uye_sifre
            // 
            this.uye_sifre.Location = new System.Drawing.Point(359, 151);
            this.uye_sifre.Name = "uye_sifre";
            this.uye_sifre.PasswordChar = '*';
            this.uye_sifre.Size = new System.Drawing.Size(258, 20);
            this.uye_sifre.TabIndex = 4;
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(507, 190);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(110, 41);
            this.giris.TabIndex = 5;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.uye_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uye_numarasi);
            this.Controls.Add(this.uye_adi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label uye_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uye_sifre;
        private System.Windows.Forms.Button giris;
        public System.Windows.Forms.TextBox uye_numarasi;
        public System.Windows.Forms.Label label3;
    }
}

