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
    public partial class kisi_edit : Form
    {
        public int kisi_id;
        public kisi_edit(int kisi_id)
        {
            InitializeComponent();
            this.kisi_id = kisi_id;
        }

        void iller_doldur()
        {
            cb_il.Items.Clear();
            cb_il.Items.Add("SİSTEME İL EKLE");

            DataTable iller = new DataTable();
            iller = new dao.diger().iller();
            DataRowCollection collection = iller.Rows;
            foreach (DataRow row in collection)
            {
                cb_il.Items.Add(row["il_isim"]);
            }
        }
        private void kisi_edit_Load(object sender, EventArgs e)
        {
            kutulari_doldur();
        }

        public void kutulari_doldur()
        {
            DataTable kisi_info = new DataTable();
            kisi_info = new dao.kisi().get_info_with_id(kisi_id);
            DataRowCollection collection = kisi_info.Rows;
            foreach(DataRow row in collection)
            {
                txt_tc.Text = row["TC"].ToString();
                txt_isim.Text = row["isim_soyisim"].ToString();
                txt_adress.Text = row["adress"].ToString();
                txt_telefon.Text = row["phone_number"].ToString();
                txt_parola.Text = row["password"].ToString();
                cb_il.Text = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));
                if (row["isBoss"].ToString() == "True") { radioButton_Patron.Checked = true; label1.Visible = true; txt_parola.Visible = true; }
                else radioButton_Normal.Checked = true;    
            }
            try { iller_doldur(); } catch (Exception hata) { MessageBox.Show(hata.Message); }
        }

        private void cb_il_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cb_il.SelectedIndex == 0)
            {
                btn_ilekle.Visible = true;
                txt_ilekle.Visible = true;
                cb_il.Visible = false;
            }
        }

        private void btn_ilekle_Click_1(object sender, EventArgs e)
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

     

        private void radioButton_Patron_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Patron.Checked)
            {
                label1.Visible = true;
                txt_parola.Visible = true;
            }
        }

        private void radioButton_Normal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Normal.Checked)
            {
                label1.Visible = false;
                txt_parola.Visible = false;
            }
        }

        bool tc_kontrol()
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

        bool bos_kontrol()
        {
            bool bos_varmi = true;
            if (txt_tc.Text == "") if (tc_kontrol()) bos_varmi = false;
            if (txt_isim.Text == "") bos_varmi = false;
            if (txt_adress.Text == "") bos_varmi = false;
            if (cb_il.Text == "") bos_varmi = false;
            if (radioButton_Patron.Checked) if (txt_parola.Text == "") bos_varmi = false;

            return bos_varmi;
        }

        private void btn_kisi_edit_Click(object sender, EventArgs e)
        {
            bool bos_varmi = bos_kontrol();
            info.kisi kisi = new info.kisi()
            {
                tc = txt_tc.Text,
                isim = txt_isim.Text,
                id = kisi_id,
                telefon = txt_telefon.Text,
                parola = txt_parola.Text,
                adress = txt_adress.Text,
                il=cb_il.Text
            };
            if (radioButton_Patron.Checked) kisi.isboss = true;
            else kisi.isboss = false;
            if (bos_varmi)
            {
                if (new dao.kisi().edit(kisi))
                {
                    MessageBox.Show("Kişi düzenlendi");
                    this.Close();
                    new yönlendirme().Show();
                }
                else MessageBox.Show("Sistem Hata 857");
            }
            else MessageBox.Show("Boş Alanlar Var !!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new yönlendirme().Show();
        }
    }
}
