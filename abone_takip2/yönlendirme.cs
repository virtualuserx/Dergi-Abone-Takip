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
    public partial class yönlendirme : Form
    {
        public yönlendirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new kisi_ekle().Show();

        }

        private void yönlendirme_Load(object sender, EventArgs e)
        {
            if (info.kisi_boss.tc == "22428846369")
            {
                button_myform.Visible = true;
            }
            else
            {
                button_myform.Visible = false;
            }
            // kasa info doldur
            lbl_gelenpara.Text=new dao.kasa().getkasagelen();
            lbl_gelecekpara.Text = new dao.kasa().getkasagelecek();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }
        
        private void btn_dergitakip_Click(object sender, EventArgs e)
        {
            this.Close();
            new dergi_takip().Show();
        }     
        private void btn_kisi_edit_Click(object sender, EventArgs e)
        {

            groupBox_kisi_edit.Visible = true;
            radioButton_numara.Visible = true;
            radioButton_tc.Visible = true;
            btn_kisiekle.Visible = false;
            radioButton_tc.Checked = false;
            radioButton_numara.Checked = false;
            btn_kisi_edit.Visible = false;
        }
        private void btn_kisi_edit_close_Click(object sender, EventArgs e)
        {
            groupBox_kisi_edit.Visible = false;
            btn_kisiekle.Visible = true;
            radioButton_tc.Checked = false;
            radioButton_numara.Checked = false;
            btn_kisi_edit.Visible = true;
        }

        private void btn_duzenlemeye_git_Click(object sender, EventArgs e)
        {
            
            try
            {
                int kisi_id;

                if (radioButton_tc.Checked)
                {
                    kisi_id = new dao.kisi().id_bul_tcile(comboBox_kisi.Text);
                    if(kisi_id>0) new kisi_edit(kisi_id).Show();
                    else throw new IndexOutOfRangeException();
                }
                else if (radioButton_numara.Checked)
                {
                    kisi_id = new dao.kisi().id_bul_numaraile(comboBox_kisi.Text);
                    if (kisi_id > 0) new kisi_edit(kisi_id).Show();
                    else throw new IndexOutOfRangeException();
                }
                else throw new IndexOutOfRangeException();
                this.Close();
            }catch(Exception hata)
            {
                MessageBox.Show("Kisi Sistemde Bulunamadı");
                this.Close();
                new yönlendirme().Show();
            }

        }

        private void radioButton_tc_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_kisi_doldur("tc");
            radioButton_numara.Visible = false;
        }

        private void radioButton_numara_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_kisi_doldur("numara");
            radioButton_tc.Visible = false;
        }

       void comboBox_kisi_doldur(string deger)
        {
            comboBox_kisi.Items.Clear();
            if(deger == "numara")
            {
                DataTable numara = new DataTable();
                numara = new dao.kisi().kisi_numara();
                DataRowCollection collection = numara.Rows;
                foreach (DataRow row in collection)
                {
                    comboBox_kisi.Items.Add(row["phone_number"]);
                }
            }
            else if(deger == "tc")
            {
                DataTable tc = new DataTable();
                tc = new dao.kisi().kisi_tc();
                DataRowCollection collection = tc.Rows;
                foreach (DataRow row in collection)
                {
                    comboBox_kisi.Items.Add(row["TC"]);
                    //        liste.Add(row["TC"]);
                }
            }

        }

        void comboBox_kisi_doldur2(string deger)
        {
            cb_kisi2.Items.Clear();
            if (deger == "numara")
            {
                DataTable numara = new DataTable();
                numara = new dao.kisi().kisi_numara();
                DataRowCollection collection = numara.Rows;
                foreach (DataRow row in collection)
                {
                    cb_kisi2.Items.Add(row["phone_number"]);
                }
            }
            else if (deger == "tc")
            {
                DataTable tc = new DataTable();
                tc = new dao.kisi().kisi_tc();
                DataRowCollection collection = tc.Rows;
                foreach (DataRow row in collection)
                {
                    cb_kisi2.Items.Add(row["TC"]);
                    //        liste.Add(row["TC"]);
                }
            }

        }

        private void btn_kisiyi_isimle_bul_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text.Trim(' ', '\n') != "")
            {
                groupBox_kisi_edit.Visible = false;
                flowLayoutPanel_info_kisi_with_isim.Visible = true;
                panel_doldur(txt_isim.Text);
            }
 
        }

        void panel_doldur(string isim)
        {
            flowLayoutPanel_info_kisi_with_isim.Controls.Clear();

            Button button = new Button();
            button.Name = "btn__kisi_sec_isim_ile_esc__btn";
            button.Text = "";
            button.Size = new Size(50, 40);
            button.BackgroundImage = global::abone_takip2.Properties.Resources.cancel;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Cursor = Cursors.NoMove2D;
            button.Click += button_esc_kisiler_Click;
            flowLayoutPanel_info_kisi_with_isim.Controls.Add(button);
            DataTable table = new DataTable();
            table = new dao.kisi().get_info_with_isim(isim);
            DataRowCollection collection = table.Rows;
            foreach(DataRow row in collection)
            {
                Button btn_person = new Button();
                btn_person.Name = row["ID"].ToString();
                btn_person.Text = "";
                btn_person.Size = new Size(50, 40);
                btn_person.BackgroundImage = global::abone_takip2.Properties.Resources.person;
                btn_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btn_person.FlatAppearance.BorderSize = 0;
                btn_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_person.Cursor = Cursors.Hand;
                string il = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));

                ToolTip info = new ToolTip();
                info.SetToolTip(btn_person, row["isim_soyisim"].ToString() + "\n" + il + "\n" + row["adress"].ToString() + "\n" + row["phone_number"].ToString() + "\n" + "Patron mu ? =>  " + row["isBoss"].ToString());

                btn_person.Click += btn_person_Click;
                flowLayoutPanel_info_kisi_with_isim.Controls.Add(btn_person);
            }
        }

        void panel_doldur2(string isim)
        {
            flowLayoutPanel_info_kisi_with_isim2.Controls.Clear();

            Button button = new Button();
            button.Name = "btn__kisi_sec_isim_ile_esc__btn";
            button.Text = "";
            button.Size = new Size(50, 40);
            button.BackgroundImage = global::abone_takip2.Properties.Resources.cancel;
            button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Cursor = Cursors.NoMove2D;
            button.Click += button_esc_kisiler2_Click;
            flowLayoutPanel_info_kisi_with_isim2.Controls.Add(button);
            DataTable table = new DataTable();
            table = new dao.kisi().get_info_with_isim(isim);
            DataRowCollection collection = table.Rows;
            foreach (DataRow row in collection)
            {
                Button btn_person = new Button();
                btn_person.Name = row["ID"].ToString();
                btn_person.Text = "";
                btn_person.Size = new Size(50, 40);
                btn_person.BackgroundImage = global::abone_takip2.Properties.Resources.person;
                btn_person.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btn_person.FlatAppearance.BorderSize = 0;
                btn_person.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn_person.Cursor = Cursors.Hand;
                string il = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));

                ToolTip info = new ToolTip();
                info.SetToolTip(btn_person, row["isim_soyisim"].ToString() + "\n" + il + "\n" + row["adress"].ToString() + "\n" + row["phone_number"].ToString() + "\n" + "Patron mu ? =>  " + row["isBoss"].ToString());

                btn_person.Click += btn_person_Click2;
                flowLayoutPanel_info_kisi_with_isim2.Controls.Add(btn_person);
            }
        }

        private void btn_person_Click2(object sender, EventArgs e)
        {
            this.Close();
            string kisii_id = ((Button)sender).Name;
            new abone_edit(Convert.ToInt32(kisii_id)).Show();
        }

        private void button_esc_kisiler2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_info_kisi_with_isim2.Controls.Clear();
            flowLayoutPanel_info_kisi_with_isim2.Visible = false;
            btn_abone_islemleri.Visible = true;         
            txt_isim2.Text = "";
        }

        private void button_esc_kisiler_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_info_kisi_with_isim.Controls.Clear();
            flowLayoutPanel_info_kisi_with_isim.Visible = false;
            btn_kisiekle.Visible = true;
            btn_kisi_edit.Visible = true;
            txt_isim.Text = "";
        }

        private void btn_person_Click(object sender, EventArgs e)
        {
            this.Close();
            string kisii_id = ((Button)sender).Name;
            new kisi_edit(Convert.ToInt32(kisii_id)).Show();
        }

        private void btn_abone_islemleri_Click(object sender, EventArgs e)
        {
            radioButton_numara2.Visible = true;
            radioButton_tc2.Visible = true;

            btn_abone_islemleri.Visible = false;
            groupBox_kisi_sec2.Visible = true;         
            radioButton_numara2.Checked = false;         
            radioButton_tc2.Checked = false;
            cb_kisi2.Items.Clear();
        }

        private void radioButton_tc2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_kisi_doldur2("tc");
            //radioButton_numara2.Visible = false;
        }

        private void radioButton_numara2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_kisi_doldur2("numara");
           // radioButton_tc2.Visible = false;
        }

        private void btn_duzenlemeye_git2_Click(object sender, EventArgs e)
        {
            try
            {
                int kisi_id;

                if (radioButton_tc2.Checked)
                {
                    kisi_id = new dao.kisi().id_bul_tcile(cb_kisi2.Text);
                    if (kisi_id > 0) new abone_edit(kisi_id).Show();
                    else throw new IndexOutOfRangeException();
                }
                else if (radioButton_numara2.Checked)
                {
                    kisi_id = new dao.kisi().id_bul_numaraile(cb_kisi2.Text);
                    if (kisi_id > 0) new abone_edit(kisi_id).Show();
                    else throw new IndexOutOfRangeException();
                }
                else throw new IndexOutOfRangeException();
                this.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Kisi Sistemde Bulunamadı");
                this.Close();
                new yönlendirme().Show();
            }
        }

        private void btn_isim_ile_bul2_Click(object sender, EventArgs e)
        {
            if (txt_isim2.Text.Trim(' ', '\n') != "")
            {
                groupBox_kisi_sec2.Visible = false;
                flowLayoutPanel_info_kisi_with_isim2.Visible = true;
                panel_doldur2(txt_isim2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox_kisi_sec2.Visible = false;
            txt_isim2.Text = "";
            btn_abone_islemleri.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new MyForm().Show();
        }

       
    }
}
