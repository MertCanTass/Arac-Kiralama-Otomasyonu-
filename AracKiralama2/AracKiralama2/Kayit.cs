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
using System.Security.Cryptography;

namespace AracKiralama2
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }

    
    Veritabani vt= new Veritabani();
        private void tx_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void btn_kayıtOl_Click(object sender, EventArgs e)
        {
            if (tx_ad.Text==""||tx_soyad.Text==""||tx_tc.Text==""||tx_tel.Text==""||tx_mail.Text==""||tx_adres.Text==""||tx_sifre.Text=="")
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
            }
            if (tx_ad.Text.Length<2)
            {
                MessageBox.Show("Ad en az 2 karakterden oluşmalıdır.");
            }
            if (tx_soyad.Text.Length<2)
            {
                MessageBox.Show("Soyad en az 2 karakterden oluşmalıdır.");
            }
            if (tx_tc.Text.Length !=11)
            {
                MessageBox.Show("Tc 11 Karakterden Oluşmalıdır.");
            }
            if (tx_tel.Text.Length !=11)
            {
                MessageBox.Show("Telefon Numarası En az 2 karakterden oluşmalıdır.");
            }
            if (tx_mail.Text=="")
            {
                MessageBox.Show("Mail Boş Bırakılamaz.");
            }
            if (tx_adres.Text=="")
            {
                MessageBox.Show("Adres Boş Bırakılamaz");
            }
            if (tx_sifre.Text.Length<5)
            {
                MessageBox.Show("Şifreniz en az 6 karakterden oluşmalıdır.");
            }



            object kayitSay = vt.Insert(@"insert into admin(adminAd,adminSoyad,adminTc,adminTel,adminMail,adminAdres,adminSifre)
                                        values('" + tx_ad.Text + "','" + tx_soyad.Text + "','" + tx_tc.Text + "','" + tx_tel.Text + "','" + tx_mail.Text + "','" + tx_adres.Text + "','" + MD5Sifrele(tx_sifre.Text) + "')");


            if (Convert.ToInt32(kayitSay) > 0)
            {
                Kayit_Load(null, null);
                MessageBox.Show("Kayıt Eklendi...");
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
