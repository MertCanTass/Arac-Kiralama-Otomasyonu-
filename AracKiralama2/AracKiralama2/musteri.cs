using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTI;

namespace AracKiralama2
{
    public partial class musteri : Form
    {
        public musteri()
        {
            InitializeComponent();
        }
        Veritabani vt=new Veritabani();
        

        private void musteri_Load(object sender, EventArgs e)
        {
            dgv_musteri.DataSource = vt.Select("select musteriId,musteriAd,musteriSoyad,musteriTc,musteriTel,musteriMail,musteriAdres from musteri");
            dgv_musteri.Columns["musteriId"].Visible = false;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text == "" || tx_soyad.Text == "" || tx_tc.Text == "" || tx_tel.Text == "" || tx_mail.Text == "" || tx_adres.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
            }
            if (tx_ad.Text.Length < 2)
            {
                MessageBox.Show("Ad en az 2 karakterden oluşmalıdır.");
            }
            if (tx_soyad.Text.Length < 2)
            {
                MessageBox.Show("Soyad en az 2 karakterden oluşmalıdır.");
            }
            if (tx_tc.Text.Length != 11)
            {
                MessageBox.Show("Tc 11 Karakterden Oluşmalıdır.");
            }
            if (tx_tel.Text.Length != 11)
            {
                MessageBox.Show("Telefon Numarası En az 2 karakterden oluşmalıdır.");
            }
            if (tx_mail.Text == "")
            {
                MessageBox.Show("Mail Boş Bırakılamaz.");
            }
            if (tx_adres.Text == "")
            {
                MessageBox.Show("Adres Boş Bırakılamaz");
            }

            object kayitSay = vt.Insert(@"insert into personel(musteriAd,musteriSoyad,musteriTc,musteriTel,musteriMail,musteriAdres)
                                        values('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + tx_tc.Text + "','" + tx_tel.Text + "','" + tx_mail.Text + "','" + tx_adres.Text + "')");


            if (Convert.ToInt32(kayitSay) > 0)
            {
                musteri_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz !!!");
                return;
            }
            if (dgv_musteri.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncellenecek satır 1 tane olmalıdır. !!!");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update musteri
                                           set musteriAd='" + tx_ad.Text + @"',      
                                               musteriSoyad='" + tx_soyad.Text + @"',
                                               musteriTc='" + tx_tc.Text + @"'
                                               musteriTel='" + tx_tel.Text + @"'
                                               musteriMail='" + tx_mail.Text + @"'
                                               musteriAdres='" + tx_adres.Text + @"'
                                            where musteriId=" + dgv_musteri.SelectedRows[0].Cells["musteriId"].Value);
            if (kayitSay > 0)
            {
                musteri_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }
        }
        private void dgv_musteri_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                tx_ad.Text = dgv_musteri.SelectedRows[0].Cells["musteriAd"].Value.ToString();
                tx_soyad.Text = dgv_musteri.SelectedRows[0].Cells["musteriSoyad"].Value.ToString();
                tx_tc.Text = dgv_musteri.SelectedRows[0].Cells["musteriTc"].Value.ToString();
                tx_tel.Text = dgv_musteri.SelectedRows[0].Cells["musteriTel"].Value.ToString();
                tx_mail.Text = dgv_musteri.SelectedRows[0].Cells["musteriMail"].Value.ToString();
                tx_adres.Text = dgv_musteri.SelectedRows[0].Cells["musteriAdres"].Value.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_musteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from musteri where musteriId =" + dgv_musteri.SelectedRows[0].Cells["musteriId"].Value);
            if (kayitSay > 0)
            {
                musteri_Load(null, null);
                MessageBox.Show("Kayıt silindi...");
            }

        }

        private void anaMenüyeDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }

        private void sayfayıYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteri_Load(null,null);
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }
    }
}
