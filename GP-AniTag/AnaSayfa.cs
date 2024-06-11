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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();     //Uygulamayı kapatır

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TumSahip formunu açar
            TumSahip sahip = new TumSahip();
            sahip.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SahipEkle formunu açar
            SahipEkle sahip = new SahipEkle();
            sahip.Show();

        }
    }
}
