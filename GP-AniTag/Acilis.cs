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
    public partial class Acilis : Form
    {
        public Acilis()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;              //zamanlayıcıyı başlatır   
            progressBar1.Value += 2;            //progressbar1 değerini 2 arttırır
            if (progressBar1.Value == 100)      //progressbar1 değeri 100 olduğunda
            {
                timer1.Enabled = false;         //zamanlayıcıyı durdurur
                Giris giris = new Giris();       //Giris formunu açar
                giris.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
