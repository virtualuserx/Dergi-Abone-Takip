using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abone_takip2
{
    public partial class Form1 : Form
    {
        public string tc = "22428846369";
        public string parola = "asdef456";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (txt_tc.Text == tc && txt_parola.Text == parola)
            {
                yönlendirme yönlendirme = new yönlendirme();
                this.Hide();
                info.kisi_boss.tc = txt_tc.Text;
                yönlendirme.Show();
            }

            else if (new dao.kisi().giris_kontrol(txt_tc.Text, txt_parola.Text))
            {
                yönlendirme yönlendirme = new yönlendirme();
                this.Hide();
                yönlendirme.Show();
            }
            else MessageBox.Show("Sistemde eşleşme bulunmadı \n Yönetici olduğunuza ve Tc , Parola kısmını dogru doldurduğunuzdan emin olunuz ");


            
          


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
