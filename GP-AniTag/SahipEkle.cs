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
    public partial class SahipEkle : Form
    {
        anidataEntities db = new anidataEntities();
        public SahipEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sahipler sahip = new Sahipler();   
            sahip.sahip_adi = sadi.Text;          //textbox1'deki değeri sahip adına atar
            sahip.sahip_tel = stel.Text;   //textbox2'deki değeri sahip telefonuna atar
            sahip.sahip_mail = smail.Text; //textbox3'deki değeri sahip mailine atar
            sahip.sahip_tc = stckn.Text;     //textbox4'deki değeri sahip tc'sine atar
            db.Sahipler.Add(sahip);        //sahipler tablosuna sahip adını ekler
            db.SaveChanges();              //değişiklikleri kaydeder
            MessageBox.Show("Sahip Eklendi");  //kullanıcıya sahip eklendi mesajını gösterir

        }
    }
}
