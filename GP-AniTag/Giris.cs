using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_AniTag
{
    public partial class Giris : Form
    {
        anidataEntities db = new anidataEntities(); //Veritabanı bağlantısı
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL Veritabanındaki kadi ve sifre bilgileri ile textboxlardaki kullanıcı adı ve şifre bilgilerini karşılaştırır
            string gelenkadi = textBox1.Text;
            string gelensifre = textBox2.Text;
            var kullanici = db.kullanici.Where(x => x.kadi == gelenkadi && x.sifre == gelensifre).FirstOrDefault();
            if (kullanici != null)
            {
                //Kullanıcı adı ve şifre doğru ise Anasayfa formunu açar
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                //Kullanıcı adı ve şifre yanlış ise hata mesajı verir
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulamayı kapatır
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hakkında formunu açar
            Hakkında hak = new Hakkında();
            hak.Show();

        }
    }
}
