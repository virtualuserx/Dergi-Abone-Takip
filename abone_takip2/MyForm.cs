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
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btn_yeni_kasa_Click(object sender, EventArgs e)
        {
            if (new dao.kasa().kasa_ekle(txt_kasa_yil.Text)) MessageBox.Show(txt_kasa_yil.Text+"  kasa eklendi");
            else MessageBox.Show("kasa eklenemedi");
        }

        private void btn_onceki_kasalari_sil_Click(object sender, EventArgs e)
        {
            if (new dao.kasa().kasalari_sil()) MessageBox.Show("Kasa Tablosu Temizlendi \n yeni Kasa Eklenebilir");
            else MessageBox.Show("Yeni Kasa Eklemeye Hazır");
        }

        private void btn_onceki_sayilari_sil_Click(object sender, EventArgs e)
        {
            if (new dao.dergi().dergileri_sil()) MessageBox.Show("Dergi Tablosu Temizlendi \n yeni Dergiler Eklenebilir");
            else MessageBox.Show("Yeni Dergi Eklemeye Hazır");
        }

        private void btn_yeni_sayi_ekle_Click(object sender, EventArgs e)
        {
            if (new dao.dergi().yeni_yil_sayilari_ekle(txt_yeni_dergiler.Text)) MessageBox.Show("Dergi Tablosuna  yeni Dergiler Eklendi");
            else MessageBox.Show("Yeni Dergi Eklemeye Başarısız");
        }

        private void btn_kisileri_temizle_Click(object sender, EventArgs e)
        {
            if(new dao.kisi().herkesi_sil()) MessageBox.Show("Herkes Silindi");
            else MessageBox.Show("Kisiler silinemedi");
        }

        private void btn_database_temizle_Click(object sender, EventArgs e)
        {
            if (new dao.diger().data_clean()) MessageBox.Show("Hersey Silindi");
            else MessageBox.Show("DataBase silinemedi");
        }

        private void btn_abone_islemleri_sil_Click(object sender, EventArgs e)
        {
            if (new dao.dergi().abone_islemleri_temizle()) MessageBox.Show("Hersey Silindi");
            else MessageBox.Show("Abone islemleri silinemedi ");
        }

        private void btn_esc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new dao.kasa().Kasalari_goster();
        }
    }
}
