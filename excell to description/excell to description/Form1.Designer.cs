namespace excell_to_description
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.ciktial = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dosyasec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ciktial
            // 
            this.ciktial.Location = new System.Drawing.Point(929, 559);
            this.ciktial.Name = "ciktial";
            this.ciktial.Size = new System.Drawing.Size(88, 29);
            this.ciktial.TabIndex = 1;
            this.ciktial.Text = "Rapor Al";
            this.ciktial.UseVisualStyleBackColor = true;
            this.ciktial.Click += new System.EventHandler(this.ciktial_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(993, 523);
            this.dataGridView1.TabIndex = 2;
            // 
            // dosyasec
            // 
            this.dosyasec.Location = new System.Drawing.Point(24, 559);
            this.dosyasec.Name = "dosyasec";
            this.dosyasec.Size = new System.Drawing.Size(88, 29);
            this.dosyasec.TabIndex = 3;
            this.dosyasec.Text = "Dosya Seç";
            this.dosyasec.UseVisualStyleBackColor = true;
            this.dosyasec.Click += new System.EventHandler(this.dosyasec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.dosyasec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ciktial);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ciktial;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dosyasec;
    }
}

