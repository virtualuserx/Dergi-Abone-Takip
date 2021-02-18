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
    public partial class kisi_ekle : Form
    {
        public kisi_ekle()
        {
            InitializeComponent();
        }

        private void kisi_ekle_Load(object sender, EventArgs e)
        {
            radioButton_Normal.Select();

            try { iller_doldur(); } catch (Exception hata) { MessageBox.Show(hata.Message); }
        }

      

        void iller_doldur() {
            cb_il.Items.Clear();
            cb_il.Items.Add("SİSTEME İL EKLE");

           DataTable iller = new DataTable();
            iller = new dao.diger().iller();
            DataRowCollection collection = iller.Rows;
            foreach(DataRow row in collection)
            {
                cb_il.Items.Add(row["il_isim"]);
            }
        }

        private bool tc_kontrol()
        {
            bool control = false;
            int rakam = 0;
            int toplam_karakter = 0;
            foreach (char a in txt_tc.Text)
            {
                if (Char.IsDigit(a)) rakam++;
                toplam_karakter++;
            }
            if (toplam_karakter == rakam && rakam == 11) control = true;
            else MessageBox.Show("TC 11 Haneli olmalıdır");
                return control;
        }
        private void btn_kisiekle_Click(object sender, EventArgs e)
        {
           

            if (tc_kontrol())
            {
                info.kisi kisi = new info.kisi();
                kisi.tc = txt_tc.Text;
                kisi.isim = txt_isim.Text;
                kisi.il = cb_il.Text;
                kisi.adress = txt_adress.Text;
                kisi.telefon = txt_telefon.Text;
                if (radioButton_Patron.Checked)
                {
                    kisi.isboss = true;
                    kisi.parola = txt_parola.Text;
                }

                else
                {
                    kisi.isboss = false;
                    kisi.parola = "";
                }


                if (new dao.kisi().kisiekle(kisi))
                {
                    MessageBox.Show("Kişi Başarıyla eklendi");
                    this.Close();
                    new yönlendirme().Show();
                }
                else
                {
                    MessageBox.Show("Kişi eklenemiyor Tc 11 haneli olduğundan ve diğer bilgilerin eksiksiz \n dolduruldugundan emin olunuz !!");
                }
            }
        }

        private void radioButton_Patron_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Normal.Visible = false;
            radioButton_Normal.Visible = false;
            txt_parola.Visible = true;
            label1.Visible = true;
        }

        private void cb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_il.SelectedIndex == 0)
            {
                btn_ilekle.Visible = true;
                txt_ilekle.Visible = true;
                cb_il.Visible = false;
            }
        }

        private void btn_ilekle_Click(object sender, EventArgs e)
        {
            if (txt_ilekle.Text.Trim(' ','\n') != "")
            {
                if (new dao.diger().il_ekle(txt_ilekle.Text.ToUpper())) MessageBox.Show("İl eklendi");

            }
            else MessageBox.Show("İl ismi boş olamaz");

            iller_doldur();
            txt_ilekle.Visible = false;
            btn_ilekle.Visible = false;
            cb_il.Visible = true;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new yönlendirme().Show();
        }
    }
}
