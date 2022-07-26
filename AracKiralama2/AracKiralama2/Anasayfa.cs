using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama2
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            this.Hide();
            personel.Show();
        }

        private void btn_arac_Click(object sender, EventArgs e)
        {
            araccs arac = new araccs();
            this.Hide();
            arac.Show();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            musteri mus =new musteri();
            this.Hide();
            mus.Show();
        }

        private void label1_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P)
            {
                Personel personel = new Personel();
                this.Hide();
                personel.Show();
            }
        }

        private void btn_personel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P)                //KISA YOL
            {
                btn_personel_Click(null, null);
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
