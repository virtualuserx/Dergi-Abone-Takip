/*
 * Button btn_info_kisi = new Button();
                          btn_info_kisi.Name = tc+"_"+ label_yil.Text + "_0" + i.ToString();
                          btn_info_kisi.Text = "";
                          btn_info_kisi.Size = new Size(33,20);
                          btn_info_kisi.BackgroundImage = global::abone_takip2.Properties.Resources._127_1275816_info_icon_info_icon_transparent_clipart;
                          btn_info_kisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                          btn_info_kisi.FlatAppearance.BorderSize = 0;
                          btn_info_kisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
*/


/*

 
  DataGridViewButtonColumn info = new DataGridViewButtonColumn();
                info.Text = "info";
                //     info.Name = tc + dergi_sayi;
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 */

//  //   dataGridView_dergi_takip.Rows.Add(dergi_sayi,tc,isim,row["kac_tane"].ToString(),row["fiyat"].ToString());

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

    public partial class dergi_takip : Form
    {

        info.   filtre filtre = new info.filtre();
        public bool filtre_var = false;
        public dergi_takip()
        {
            InitializeComponent();
        }

        private void dergi_takip_Load(object sender, EventArgs e)
        {
            label_yil.Text = DateTime.Now.Year.ToString();
            radioButton_odendi.Checked = true;
            radioButton_teslimedilmedi.Checked = true;
            radioButton_sayi_tumu.Checked = true;
            label_teslim_ve_odendi_doldur();
            btn_listele_Click(new object() , new EventArgs());
           

        }

        void label_teslim_ve_odendi_doldur()
        {
            int teslim_edildi = 0;
            int odendi = 0;
            int sayi_tumu = 0;
            string dergi_sayi=label_yil.Text+"_"+sayi_control();
            if (dergi_sayi.Split('_')[1] != "tumu")
            {
                teslim_edildi = new dao.dergi().sayi_teslimedildi(dergi_sayi);
                odendi = new dao.dergi().sayi_odendi(dergi_sayi);
                sayi_tumu = new dao.dergi().sayi_tumu(dergi_sayi);
            }
            else
            {
                for(int i = 1; i <= 6; i++)
                {
                    dergi_sayi = label_yil.Text + "_0" + i.ToString();
                    teslim_edildi += new dao.dergi().sayi_teslimedildi(dergi_sayi);
                    odendi += new dao.dergi().sayi_odendi(dergi_sayi);
                    sayi_tumu += new dao.dergi().sayi_tumu(dergi_sayi);
                }
            }
            label_odendi_orani.Text = odendi.ToString() + " / " + sayi_tumu.ToString();
            label_teslim_edildi_orani.Text = teslim_edildi.ToString() + " / " + sayi_tumu.ToString();

        }

        public string sayi_control()
        {
            string dergi_sayi="";

            if (radioButton_sayi_tumu.Checked) dergi_sayi = "tumu";
            else if (radioButton_sayi1.Checked) dergi_sayi = "01";
            else if (radioButton_sayi2.Checked) dergi_sayi = "02";
            else if (radioButton_sayi3.Checked) dergi_sayi = "03";
            else if (radioButton_sayi4.Checked) dergi_sayi = "04";
            else if (radioButton_sayi5.Checked) dergi_sayi = "05";
            else if (radioButton_sayi6.Checked) dergi_sayi = "06";
            return dergi_sayi;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            label_teslim_ve_odendi_doldur();
     /**/   dataGridView_dergi_takip.Columns.Clear();
            string dergi_sayi=label_yil.Text+"_"+sayi_control();

            if (dergi_sayi.Split('_')[1] == "tumu") _DataGridView_doldur_tumu();
            else _DataGridView_doldur(dergi_sayi);       
        }
        private void _DataGridView_doldur(string dergi_sayi)
        {
            //
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Sayı", typeof(string)));
            dt.Columns.Add(new DataColumn("Tc", typeof(string)));
            dt.Columns.Add(new DataColumn("İsim", typeof(string)));
            dt.Columns.Add(new DataColumn("Kac tane", typeof(string)));
            dt.Columns.Add(new DataColumn("Fiyat", typeof(string)));
            //
          
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = global::abone_takip2.Properties.Resources._127_1275816_info_icon_info_icon_transparent_clipart;
            img.HeaderText = "Detay";
            img.Width = 50;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            img.Description = "Stretched";

            DataGridViewImageColumn img_print = new DataGridViewImageColumn();
            img_print.Image = global::abone_takip2.Properties.Resources.Print;
            img_print.HeaderText = "PDF";
            img_print.Width = 50;
            img_print.ImageLayout = DataGridViewImageCellLayout.Stretch;
            img_print.Description = "Stretched";

            DataTable table = new DataTable();
            table = new dao.dergi().takip(dergi_sayi, radioButton_teslimedildi.Checked, radioButton_odendi.Checked);
            DataRowCollection collection = table.Rows;
            foreach (DataRow row in collection)
            {

                

                string tc = "";
                string isim = "";
                try
                {
                     tc = new dao.kisi().bul_tc(Convert.ToInt32(row["abone_id"]));
                     isim = new dao.kisi().bul_isim(Convert.ToInt32(row["abone_id"]));
                }
                catch (Exception hata)
                {
                    MessageBox.Show("Sistemden Bilgisi Çekilemeyen Kişiler Var");
                }

                DataRow dr = dt.NewRow();
                dr[0] = dergi_sayi;
                dr[1] = tc;
                dr[2] = isim;
                dr[3] = row["kac_tane"].ToString();
                dr[4] = row["fiyat"].ToString();
                dt.Rows.Add(dr);

            }
            //
            dataGridView_dergi_takip.DataSource = dt;
            dataGridView_dergi_takip.Columns.Add(img);
            dataGridView_dergi_takip.Columns.Add(img_print);

            //    
        }

        private void _DataGridView_doldur_tumu()
        {
            //
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Sayı", typeof(string)));
            dt.Columns.Add(new DataColumn("Tc", typeof(string)));
            dt.Columns.Add(new DataColumn("İsim", typeof(string)));
            dt.Columns.Add(new DataColumn("Kac tane", typeof(string)));
            dt.Columns.Add(new DataColumn("Fiyat", typeof(string)));
            //

            //
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            img.Image = global::abone_takip2.Properties.Resources._127_1275816_info_icon_info_icon_transparent_clipart;
            img.HeaderText = "Detay";
            img.Width = 50;
            img.ImageLayout = DataGridViewImageCellLayout.Stretch;
            img.Description = "Stretched";
            //

            DataGridViewImageColumn img_print = new DataGridViewImageColumn();
            img_print.Image = global::abone_takip2.Properties.Resources.Print;
            img_print.HeaderText = "PDF";
            img_print.Width = 50;
            img_print.ImageLayout = DataGridViewImageCellLayout.Stretch;
            img_print.Description = "Stretched";


            for (int i = 1; i <= 6; i++)
            {
               string dergi_sayi = label_yil.Text + "_0" + i.ToString();

                DataTable table = new DataTable();
                table = new dao.dergi().takip(dergi_sayi, radioButton_teslimedildi.Checked, radioButton_odendi.Checked);
                DataRowCollection collection = table.Rows;
                foreach (DataRow row in collection)
                {
                    string tc = "";
                    string isim = "";
                    try
                    {
                         tc = new dao.kisi().bul_tc(Convert.ToInt32(row["abone_id"]));
                         isim = new dao.kisi().bul_isim(Convert.ToInt32(row["abone_id"]));
                    }catch(Exception hata)
                    {
                        MessageBox.Show("Sistemden Bilgisi Çekilemeyen Kişiler Var");
                    }
                    DataRow dr = dt.NewRow();
                    dr[0] = dergi_sayi;
                    dr[1] = tc;
                    dr[2] = isim;
                    dr[3] = row["kac_tane"].ToString();
                    dr[4] = row["fiyat"].ToString();
                    dt.Rows.Add(dr);
                }   
            }

            //
            dataGridView_dergi_takip.DataSource = dt;
            dataGridView_dergi_takip.Columns.Add(img);
            dataGridView_dergi_takip.Columns.Add(img_print);

            //    
        }
        private void dataGridView_dergi_takip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Index == 5 &&
       e.RowIndex >= 0 )
            {
                
                string tc = dataGridView_dergi_takip.CurrentRow.Cells[1].Value.ToString();
                string isim = "";
                string il = "";
                string adress = "";
                string phone_number = "";

                DataTable table = new DataTable();

                dao.kisi kisi = new dao.kisi();
                table =   kisi.get_info_with_tc(tc);
                DataRowCollection collection = table.Rows;
                foreach(DataRow row in collection)
                {
                    isim = row["isim_soyisim"].ToString();
                    il = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));
                    adress = row["adress"].ToString();
                    phone_number = row["phone_number"].ToString();
                }
                MessageBox.Show(tc+"\n"+isim+"\n" +il + "\n" +adress + "\n" +phone_number);

            }

            else if (senderGrid.Columns[e.ColumnIndex].Index == 6 &&  e.RowIndex >= 0)
            {
                string tc = dataGridView_dergi_takip.CurrentRow.Cells[1].Value.ToString();
                string isim = "";
                string il = "";
                string adress = "";
                string phone_number = "";

                DataTable table = new DataTable();

                dao.kisi kisi = new dao.kisi();
                table = kisi.get_info_with_tc(tc);
                DataRowCollection collection = table.Rows;
                foreach (DataRow row in collection)
                {
                    isim = row["isim_soyisim"].ToString();
                    il = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));
                    adress = row["adress"].ToString();
                    phone_number = row["phone_number"].ToString();
                }

                info.kisi kisii = new info.kisi() { tc = tc, isim = isim, il = il, adress = adress, telefon = phone_number };
                string sayi= dataGridView_dergi_takip.CurrentRow.Cells[0].Value.ToString();
                string adet= dataGridView_dergi_takip.CurrentRow.Cells[3].Value.ToString();
                string fiyat= dataGridView_dergi_takip.CurrentRow.Cells[4].Value.ToString();
                bool odendi = radioButton_odendi.Checked;
                new pdf_olustur(kisii,sayi,adet,fiyat,odendi).Show();

            }

        }

      

       

      

       

        private void btn_filtrele_Click(object sender, EventArgs e)
        {
            filtre_var = true;
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new yönlendirme().Show();
        }


































        /*  private void dataGridView_dergi_takip_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              if (e.ColumnIndex == 5)
              {

                  string tc = dataGridView_dergi_takip.CurrentRow.Cells[1].Value.ToString();
                  string isim = "";
                  string il = "";
                  string adress = "";
                  string phone_number = "";

                  DataTable table = new DataTable();

                  dao.kisi kisi = new dao.kisi();
                  table = kisi.get_info_with_tc(tc);
                  DataRowCollection collection = table.Rows;
                  foreach (DataRow row in collection)
                  {
                      isim = row["isim_soyisim"].ToString();
                      il = new dao.diger().il_isim(Convert.ToInt32(row["il_id"]));
                      adress = row["adress"].ToString();
                      phone_number = row["phone_number"].ToString();
                  }
                  MessageBox.Show(tc + "\n" + isim + "\n" + il + "\n" + adress + "\n" + phone_number);
              }
          }

      /**/










    }
}
