namespace banka_personel
{
    partial class yonetici
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
            this.yonetici_adi = new System.Windows.Forms.Label();
            this.yonetici_soyadi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yonetici_adi
            // 
            this.yonetici_adi.AutoSize = true;
            this.yonetici_adi.Location = new System.Drawing.Point(83, 13);
            this.yonetici_adi.Name = "yonetici_adi";
            this.yonetici_adi.Size = new System.Drawing.Size(20, 13);
            this.yonetici_adi.TabIndex = 0;
            this.yonetici_adi.Text = "Ad";
            // 
            // yonetici_soyadi
            // 
            this.yonetici_soyadi.AutoSize = true;
            this.yonetici_soyadi.Location = new System.Drawing.Point(146, 13);
            this.yonetici_soyadi.Name = "yonetici_soyadi";
            this.yonetici_soyadi.Size = new System.Drawing.Size(37, 13);
            this.yonetici_soyadi.TabIndex = 1;
            this.yonetici_soyadi.Text = "Soyad";
            this.yonetici_soyadi.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yönetici :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(838, 245);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 325);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yonetici_soyadi);
            this.Controls.Add(this.yonetici_adi);
            this.Name = "yonetici";
            this.Text = "yonetici";
            this.Load += new System.EventHandler(this.yonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label yonetici_adi;
        public System.Windows.Forms.Label yonetici_soyadi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}