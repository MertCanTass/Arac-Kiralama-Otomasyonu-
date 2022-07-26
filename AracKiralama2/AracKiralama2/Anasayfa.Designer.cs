namespace AracKiralama2
{
    partial class Anasayfa
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
            this.btn_personel = new System.Windows.Forms.Button();
            this.btn_arac = new System.Windows.Forms.Button();
            this.btn_musteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_personel
            // 
            this.btn_personel.Location = new System.Drawing.Point(99, 102);
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.Size = new System.Drawing.Size(144, 112);
            this.btn_personel.TabIndex = 0;
            this.btn_personel.Text = "Personel İşlemleri";
            this.btn_personel.UseVisualStyleBackColor = true;
            this.btn_personel.Click += new System.EventHandler(this.btn_personel_Click);
            this.btn_personel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_personel_KeyDown);
            // 
            // btn_arac
            // 
            this.btn_arac.Location = new System.Drawing.Point(249, 102);
            this.btn_arac.Name = "btn_arac";
            this.btn_arac.Size = new System.Drawing.Size(144, 112);
            this.btn_arac.TabIndex = 1;
            this.btn_arac.Text = "Araç İşlemleri ";
            this.btn_arac.UseVisualStyleBackColor = true;
            this.btn_arac.Click += new System.EventHandler(this.btn_arac_Click);
            // 
            // btn_musteri
            // 
            this.btn_musteri.Location = new System.Drawing.Point(399, 102);
            this.btn_musteri.Name = "btn_musteri";
            this.btn_musteri.Size = new System.Drawing.Size(144, 112);
            this.btn_musteri.TabIndex = 2;
            this.btn_musteri.Text = "Muşteri İşlemleri";
            this.btn_musteri.UseVisualStyleBackColor = true;
            this.btn_musteri.Click += new System.EventHandler(this.btn_musteri_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(670, 316);
            this.Controls.Add(this.btn_musteri);
            this.Controls.Add(this.btn_arac);
            this.Controls.Add(this.btn_personel);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_personel;
        private System.Windows.Forms.Button btn_arac;
        private System.Windows.Forms.Button btn_musteri;
    }
}