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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Veritabani vt= new Veritabani();
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
        private void btn_kayıtol_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            this.Hide();
            kayit.Show();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            if (tx_tc.Text == "" || tx_sifre.Text == "")
            {
                MessageBox.Show("Tc Kimlik Numaranız veya Şifrenizi Girmediniz !!!");
            }
            DataTable dt = vt.Select(@"select adminId,adminTc,adminSifre from admin where adminTc=" + tx_tc.Text + "and adminSifre='" + MD5Sifrele(tx_sifre.Text) + "'");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı adın veya şifre hatalı...");
                tx_tc.Text = tx_sifre.Text = "";
                return;
            }
            Anasayfa ana = new Anasayfa();
            this.Hide();
            ana.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
