namespace AracKiralama2
{
    partial class araccs
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
            this.tx_marka = new System.Windows.Forms.TextBox();
            this.tx_model = new System.Windows.Forms.TextBox();
            this.tx_plaka = new System.Windows.Forms.TextBox();
            this.cbx_renk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.dgv_arac = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arac)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_marka
            // 
            this.tx_marka.Location = new System.Drawing.Point(91, 26);
            this.tx_marka.Name = "tx_marka";
            this.tx_marka.Size = new System.Drawing.Size(100, 20);
            this.tx_marka.TabIndex = 0;
            // 
            // tx_model
            // 
            this.tx_model.Location = new System.Drawing.Point(91, 52);
            this.tx_model.Name = "tx_model";
            this.tx_model.Size = new System.Drawing.Size(100, 20);
            this.tx_model.TabIndex = 1;
            // 
            // tx_plaka
            // 
            this.tx_plaka.Location = new System.Drawing.Point(268, 52);
            this.tx_plaka.Name = "tx_plaka";
            this.tx_plaka.Size = new System.Drawing.Size(100, 20);
            this.tx_plaka.TabIndex = 2;
            // 
            // cbx_renk
            // 
            this.cbx_renk.FormattingEnabled = true;
            this.cbx_renk.Items.AddRange(new object[] {
            "BEYAZ",
            "SİYAH",
            "GRİ",
            "MAVİ",
            "LACİVERT",
            "KIRMIZI",
            "MOR"});
            this.cbx_renk.Location = new System.Drawing.Point(268, 25);
            this.cbx_renk.Name = "cbx_renk";
            this.cbx_renk.Size = new System.Drawing.Size(100, 21);
            this.cbx_renk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marka :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Renk :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plaka :";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(74, 128);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 8;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(185, 128);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 9;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(293, 128);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 10;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // dgv_arac
            // 
            this.dgv_arac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arac.Location = new System.Drawing.Point(38, 208);
            this.dgv_arac.Name = "dgv_arac";
            this.dgv_arac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_arac.Size = new System.Drawing.Size(722, 230);
            this.dgv_arac.TabIndex = 11;
            this.dgv_arac.SelectionChanged += new System.EventHandler(this.dgv_arac_SelectionChanged);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(393, 128);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.Text = "Geri Dön";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // araccs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.dgv_arac);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_renk);
            this.Controls.Add(this.tx_plaka);
            this.Controls.Add(this.tx_model);
            this.Controls.Add(this.tx_marka);
            this.Name = "araccs";
            this.Text = "araccs";
            this.Load += new System.EventHandler(this.araccs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_marka;
        private System.Windows.Forms.TextBox tx_model;
        private System.Windows.Forms.TextBox tx_plaka;
        private System.Windows.Forms.ComboBox cbx_renk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.DataGridView dgv_arac;
        private System.Windows.Forms.Button btn_geri;
    }
}