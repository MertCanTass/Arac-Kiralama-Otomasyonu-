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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }
        Veritabani vt=new Veritabani();
       

        private void Personel_Load(object sender, EventArgs e)
        {
            dgv_personel.DataSource = vt.Select("select personelId,personelAd,personelSoyad,personelTc,personelTel,personelMail,personelAdres from personel");
            dgv_personel.Columns["personelId"].Visible = false;
            
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

            object kayitSay = vt.Insert(@"insert into personel(personelAd,personelSoyad,personelTc,personelTel,personelMail,personelAdres)
                                        values('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + tx_tc.Text + "','" + tx_tel.Text + "','" + tx_mail.Text + "','" + tx_adres.Text + "')");


            if (Convert.ToInt32(kayitSay) > 0)
            {
                Personel_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz !!!");
                return;
            }
            if (dgv_personel.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncellenecek satır 1 tane olmalıdır. !!!");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update personel
                                           set personelAd='" + tx_ad.Text + @"',      
                                               personelSoyad='" + tx_soyad.Text + @"',
                                               personelTc='" + tx_tc.Text + @"',
                                               personelTel='" + tx_tel.Text + @"',
                                               personelMail='" + tx_mail.Text + @"',
                                               personelAdres='" + tx_adres.Text + @"'
                                            where personelId=" + dgv_personel.SelectedRows[0].Cells["personelId"].Value);
            if (kayitSay > 0)
            {
                Personel_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }
        }
        private void dgv_personel_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                tx_ad.Text = dgv_personel.SelectedRows[0].Cells["personelAd"].Value.ToString();
                tx_soyad.Text = dgv_personel.SelectedRows[0].Cells["personelSoyad"].Value.ToString();
                tx_tc.Text = dgv_personel.SelectedRows[0].Cells["personelTc"].Value.ToString();
                tx_tel.Text = dgv_personel.SelectedRows[0].Cells["personelTel"].Value.ToString();
                tx_mail.Text = dgv_personel.SelectedRows[0].Cells["personelMail"].Value.ToString();
                tx_adres.Text = dgv_personel.SelectedRows[0].Cells["personelAdres"].Value.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_personel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from personel where personelId =" + dgv_personel.SelectedRows[0].Cells["personelId"].Value);
            if (kayitSay > 0)
            {
                Personel_Load(null, null);
                MessageBox.Show("Kayıt silindi...");
            }
           
             
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }
    }
}
