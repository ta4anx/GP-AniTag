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
    public partial class TumSahip : Form
    {
        public TumSahip()
        {
            InitializeComponent();
        }

        private void TumSahip_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'anidataDataSet.Sahipler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sahiplerTableAdapter.Fill(this.anidataDataSet.Sahipler);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sahip = dataGridView1.CurrentRow.Cells[0].Value.ToString();


        }
    }
}
