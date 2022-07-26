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
    public partial class araccs : Form
    {
        public araccs()
        {
            InitializeComponent();
        }
        Veritabani vt = new Veritabani();

        private void araccs_Load(object sender, EventArgs e)
        {

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (tx_marka.Text == "" || tx_model.Text == "" ||cbx_renk.Text==""|| tx_plaka.Text == "")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz..");
            }
            if (tx_marka.Text.Length < 2)
            {
                MessageBox.Show("Marka en az 2 karakterden oluşmalıdır.");
            }
            if (tx_model.Text.Length < 2)
            {
                MessageBox.Show("Model en az 2 karakterden oluşmalıdır.");
            }
            if (cbx_renk.Text=="")
            {
                MessageBox.Show("Arac Rengi Boş Bırakılamaz.");
            }
            if (tx_plaka.Text.Length < 6)
            {
                MessageBox.Show("Plaka en az 6 karakterden oluşmalıdır.");
            }
            object kayitSay = vt.Insert(@"insert into arac(aracMarka,aracModel,aracRenk,aracPlaka)
                                        values('" + tx_marka.Text + "','" + tx_model.Text + "','" + cbx_renk.Text + "','" + tx_plaka.Text + "')");


            if (Convert.ToInt32(kayitSay) > 0)
            {
                araccs_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }

        

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_arac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellenecek satırı seçiniz !!!");
                return;
            }
            if (dgv_arac.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncellenecek satır 1 tane olmalıdır. !!!");
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_arac
                                           set aracMarka='" + tx_marka.Text + @"',      
                                               aracModel='" + tx_model.Text + @"',
                                               aracRenk='"  + cbx_renk+@"',
                                               aracPlaka='" + tx_plaka.Text + @"'
                                              
                                            where aracId=" + dgv_arac.SelectedRows[0].Cells["aracId"].Value);
            if (kayitSay > 0)
            {
                araccs_Load(null, null);
                MessageBox.Show("Kayıt güncellendi...");
            }
        }
        private void dgv_arac_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_arac.SelectedRows.Count == 0)
            {
                return;
            }
            else
            {
                tx_marka.Text = dgv_arac.SelectedRows[0].Cells["aracMarka"].Value.ToString();
                tx_model.Text = dgv_arac.SelectedRows[0].Cells["aracModel"].Value.ToString();
                cbx_renk.Text = dgv_arac.SelectedRows[0].Cells["aracRenk"].Value.ToString();
                tx_plaka.Text = dgv_arac.SelectedRows[0].Cells["aracPlaka"].Value.ToString();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_arac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek satırı seçiniz !!!");
                return;
            }

            int kayitSay = vt.UpdateDelete("Delete from arac where aracId =" + dgv_arac.SelectedRows[0].Cells["aracId"].Value);
            if (kayitSay > 0)
            {
                araccs_Load(null, null);
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
