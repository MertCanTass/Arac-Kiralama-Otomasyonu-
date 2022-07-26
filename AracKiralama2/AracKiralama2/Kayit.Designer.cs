namespace AracKiralama2
{
    partial class Kayit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_ad = new System.Windows.Forms.TextBox();
            this.tx_soyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tx_tc = new System.Windows.Forms.TextBox();
            this.tx_tel = new System.Windows.Forms.TextBox();
            this.tx_mail = new System.Windows.Forms.TextBox();
            this.tx_adres = new System.Windows.Forms.TextBox();
            this.tx_sifre = new System.Windows.Forms.TextBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayıtOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail :";
            // 
            // tx_ad
            // 
            this.tx_ad.Location = new System.Drawing.Point(108, 28);
            this.tx_ad.Name = "tx_ad";
            this.tx_ad.Size = new System.Drawing.Size(100, 20);
            this.tx_ad.TabIndex = 6;
            this.tx_ad.TextChanged += new System.EventHandler(this.tx_ad_TextChanged);
            // 
            // tx_soyad
            // 
            this.tx_soyad.Location = new System.Drawing.Point(108, 55);
            this.tx_soyad.Name = "tx_soyad";
            this.tx_soyad.Size = new System.Drawing.Size(100, 20);
            this.tx_soyad.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Şifre :";
            // 
            // tx_tc
            // 
            this.tx_tc.Location = new System.Drawing.Point(108, 81);
            this.tx_tc.Name = "tx_tc";
            this.tx_tc.Size = new System.Drawing.Size(100, 20);
            this.tx_tc.TabIndex = 9;
            // 
            // tx_tel
            // 
            this.tx_tel.Location = new System.Drawing.Point(108, 116);
            this.tx_tel.Name = "tx_tel";
            this.tx_tel.Size = new System.Drawing.Size(100, 20);
            this.tx_tel.TabIndex = 10;
            // 
            // tx_mail
            // 
            this.tx_mail.Location = new System.Drawing.Point(108, 147);
            this.tx_mail.Name = "tx_mail";
            this.tx_mail.Size = new System.Drawing.Size(100, 20);
            this.tx_mail.TabIndex = 11;
            // 
            // tx_adres
            // 
            this.tx_adres.Location = new System.Drawing.Point(108, 173);
            this.tx_adres.Name = "tx_adres";
            this.tx_adres.Size = new System.Drawing.Size(100, 20);
            this.tx_adres.TabIndex = 12;
            // 
            // tx_sifre
            // 
            this.tx_sifre.Location = new System.Drawing.Point(108, 199);
            this.tx_sifre.Name = "tx_sifre";
            this.tx_sifre.Size = new System.Drawing.Size(100, 20);
            this.tx_sifre.TabIndex = 13;
            this.tx_sifre.UseSystemPasswordChar = true;
            // 
            // btn_geri
            // 
            this.btn_geri.Image = global::AracKiralama2.Properties.Resources.undo_24px;
            this.btn_geri.Location = new System.Drawing.Point(186, 238);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(100, 72);
            this.btn_geri.TabIndex = 15;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayıtOl
            // 
            this.btn_kayıtOl.Image = global::AracKiralama2.Properties.Resources.Done_50px;
            this.btn_kayıtOl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kayıtOl.Location = new System.Drawing.Point(32, 238);
            this.btn_kayıtOl.Name = "btn_kayıtOl";
            this.btn_kayıtOl.Size = new System.Drawing.Size(100, 72);
            this.btn_kayıtOl.TabIndex = 14;
            this.btn_kayıtOl.Text = "Kayıt Ol";
            this.btn_kayıtOl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kayıtOl.UseVisualStyleBackColor = true;
            this.btn_kayıtOl.Click += new System.EventHandler(this.btn_kayıtOl_Click);
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(330, 371);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kayıtOl);
            this.Controls.Add(this.tx_sifre);
            this.Controls.Add(this.tx_adres);
            this.Controls.Add(this.tx_mail);
            this.Controls.Add(this.tx_tel);
            this.Controls.Add(this.tx_tc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tx_soyad);
            this.Controls.Add(this.tx_ad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kayit";
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_ad;
        private System.Windows.Forms.TextBox tx_soyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tx_tc;
        private System.Windows.Forms.TextBox tx_tel;
        private System.Windows.Forms.TextBox tx_mail;
        private System.Windows.Forms.TextBox tx_adres;
        private System.Windows.Forms.TextBox tx_sifre;
        private System.Windows.Forms.Button btn_kayıtOl;
        private System.Windows.Forms.Button btn_geri;
    }
}