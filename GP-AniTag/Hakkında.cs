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
    public partial class Hakkında : Form
    {
        public Hakkında()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //web tarayıcısında GitHub linkini açar
            try
            {
                System.Diagnostics.Process.Start("https://www.github.com/ta4anx/AniTag/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Link açılırken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
