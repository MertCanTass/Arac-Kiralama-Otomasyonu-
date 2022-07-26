namespace AracKiralama2
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
            this.tx_tc = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.lbl_kulAd = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_girisYap = new System.Windows.Forms.Button();
            this.btn_kayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_tc
            // 
            this.tx_tc.Location = new System.Drawing.Point(122, 34);
            this.tx_tc.Name = "tx_tc";
            this.tx_tc.Size = new System.Drawing.Size(100, 20);
            this.tx_tc.TabIndex = 0;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(122, 103);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 1;
            // 
            // lbl_kulAd
            // 
            this.lbl_kulAd.AutoSize = true;
            this.lbl_kulAd.Location = new System.Drawing.Point(52, 37);
            this.lbl_kulAd.Name = "lbl_kulAd";
            this.lbl_kulAd.Size = new System.Drawing.Size(64, 13);
            this.lbl_kulAd.TabIndex = 2;
            this.lbl_kulAd.Text = "Kullanıcı Adı";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(77, 106);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(28, 13);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Şifre";
            // 
            // btn_girisYap
            // 
            this.btn_girisYap.Location = new System.Drawing.Point(133, 146);
            this.btn_girisYap.Name = "btn_girisYap";
            this.btn_girisYap.Size = new System.Drawing.Size(75, 23);
            this.btn_girisYap.TabIndex = 4;
            this.btn_girisYap.Text = "Giriş Yap";
            this.btn_girisYap.UseVisualStyleBackColor = true;
            this.btn_girisYap.Click += new System.EventHandler(this.btn_girisYap_Click);
            // 
            // btn_kayıtol
            // 
            this.btn_kayıtol.Location = new System.Drawing.Point(133, 175);
            this.btn_kayıtol.Name = "btn_kayıtol";
            this.btn_kayıtol.Size = new System.Drawing.Size(75, 23);
            this.btn_kayıtol.TabIndex = 5;
            this.btn_kayıtol.Text = "Kayit Ol";
            this.btn_kayıtol.UseVisualStyleBackColor = true;
            this.btn_kayıtol.Click += new System.EventHandler(this.btn_kayıtol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(305, 259);
            this.Controls.Add(this.btn_kayıtol);
            this.Controls.Add(this.btn_girisYap);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_kulAd);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_tc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_tc;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Label lbl_kulAd;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_girisYap;
        private System.Windows.Forms.Button btn_kayıtol;
    }
}

