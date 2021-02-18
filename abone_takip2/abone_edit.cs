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
    public partial class abone_edit : Form
    {
        public int kisi_id;
        public abone_edit(int kisi_id)
        {
            InitializeComponent();
            this.kisi_id = kisi_id;
        }

        private void abone_edit_Load(object sender, EventArgs e)
        {
            sayfayi_doldur();
        }

       void sayfayi_doldur()
        {
            label_dergi_isim_doldur();
            programi_kullanan_kisi_doldur();
            checkboxlara_tooltip_ata();
            if (onceki_abone())
            {
                alinan_sayilari_isaretle();
                textbox_miktar_doldur();
                textbox_fiyat_doldur();
                checkbox_odendi_doldur();             
                checkbox_teslimedildi_doldur();
            }
            else
            {

            }
        }

        bool onceki_abone()
        {
            return new dao.dergi().abone_mi(kisi_id);
        }

        void alinan_sayilari_isaretle()
        {
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi1.Text)) label_sayi1.BackColor = Color.Green;
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi2.Text)) label_sayi2.BackColor = Color.Green;
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi3.Text)) label_sayi3.BackColor = Color.Green;
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi4.Text)) label_sayi4.BackColor = Color.Green;
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi5.Text)) label_sayi5.BackColor = Color.Green;
            if (new dao.dergi().dergiye_abone_mi(kisi_id, label_sayi6.Text)) label_sayi6.BackColor = Color.Green;
        }

        void textbox_fiyat_doldur()
        {
            if (label_sayi1.BackColor == Color.Green) txt_fiyat_sayi1.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi1.Text);
            if (label_sayi2.BackColor == Color.Green) txt_fiyat_sayi2.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi2.Text);
            if (label_sayi3.BackColor == Color.Green) txt_fiyat_sayi3.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi3.Text);
            if (label_sayi4.BackColor == Color.Green) txt_fiyat_sayi4.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi4.Text);
            if (label_sayi5.BackColor == Color.Green) txt_fiyat_sayi5.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi5.Text);
            if (label_sayi6.BackColor == Color.Green) txt_fiyat_sayi6.Text = new dao.dergi().abonenin_sayi_fiyati(kisi_id, label_sayi6.Text);
        }

        void textbox_miktar_doldur()
        {
            if (label_sayi1.BackColor == Color.Green) txt_miktar_sayi1.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi1.Text);
            if (label_sayi2.BackColor == Color.Green) txt_miktar_sayi2.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi2.Text);
            if (label_sayi3.BackColor == Color.Green) txt_miktar_sayi3.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi3.Text);
            if (label_sayi4.BackColor == Color.Green) txt_miktar_sayi4.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi4.Text);
            if (label_sayi5.BackColor == Color.Green) txt_miktar_sayi5.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi5.Text);
            if (label_sayi6.BackColor == Color.Green) txt_miktar_sayi6.Text = new dao.dergi().abonenin_sayi_miktari(kisi_id, label_sayi6.Text);
        }

        void checkbox_odendi_doldur()
        {
            if (label_sayi1.BackColor == Color.Green) checkBox_odendi_sayi1.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi1.Text);
            if (label_sayi2.BackColor == Color.Green) checkBox_odendi_sayi2.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi2.Text);
            if (label_sayi3.BackColor == Color.Green) checkBox_odendi_sayi3.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi3.Text);
            if (label_sayi4.BackColor == Color.Green) checkBox_odendi_sayi4.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi4.Text);
            if (label_sayi5.BackColor == Color.Green) checkBox_odendi_sayi5.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi5.Text);
            if (label_sayi6.BackColor == Color.Green) checkBox_odendi_sayi6.Checked = new dao.dergi().sayi_odendi_mi(kisi_id, label_sayi6.Text);
        }

        void checkbox_tumunu_ode()
        {
            if (label_sayi1.BackColor == Color.Green) checkBox_odendi_sayi1.Checked = true;
            if (label_sayi2.BackColor == Color.Green) checkBox_odendi_sayi2.Checked = true;
            if (label_sayi3.BackColor == Color.Green) checkBox_odendi_sayi3.Checked = true;
            if (label_sayi4.BackColor == Color.Green) checkBox_odendi_sayi4.Checked = true;
            if (label_sayi5.BackColor == Color.Green) checkBox_odendi_sayi5.Checked = true;
            if (label_sayi6.BackColor == Color.Green) checkBox_odendi_sayi6.Checked = true;
        }

        void checkbox_teslimedildi_doldur()
        {
            if (label_sayi1.BackColor == Color.Green) checkBox_teslimedildi_sayi1.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi1.Text);
            if (label_sayi2.BackColor == Color.Green) checkBox_teslimedildi_sayi2.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi2.Text);
            if (label_sayi3.BackColor == Color.Green) checkBox_teslimedildi_sayi3.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi3.Text);
            if (label_sayi4.BackColor == Color.Green) checkBox_teslimedildi_sayi4.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi4.Text);
            if (label_sayi5.BackColor == Color.Green) checkBox_teslimedildi_sayi5.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi5.Text);
            if (label_sayi6.BackColor == Color.Green) checkBox_teslimedildi_sayi6.Checked = new dao.dergi().sayi_teslimedildi_mi(kisi_id, label_sayi6.Text);
        }

        void checkbox_teslim_et()
        {
            if (label_sayi1.BackColor == Color.Green) checkBox_teslimedildi_sayi1.Checked = true;
            if (label_sayi2.BackColor == Color.Green) checkBox_teslimedildi_sayi2.Checked = true;
            if (label_sayi3.BackColor == Color.Green) checkBox_teslimedildi_sayi3.Checked = true;
            if (label_sayi4.BackColor == Color.Green) checkBox_teslimedildi_sayi4.Checked = true;
            if (label_sayi5.BackColor == Color.Green) checkBox_teslimedildi_sayi5.Checked = true;
            if (label_sayi6.BackColor == Color.Green) checkBox_teslimedildi_sayi6.Checked = true;
        }
        void checkboxlara_tooltip_ata()
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(checkBox_odendi_sayi1, "Ödendi");
            tool.SetToolTip(checkBox_odendi_sayi2, "Ödendi");
            tool.SetToolTip(checkBox_odendi_sayi3, "Ödendi");
            tool.SetToolTip(checkBox_odendi_sayi4, "Ödendi");
            tool.SetToolTip(checkBox_odendi_sayi5, "Ödendi");
            tool.SetToolTip(checkBox_odendi_sayi6, "Ödendi");

            tool.SetToolTip(checkBox_teslimedildi_sayi1, "Teslim edildi");
            tool.SetToolTip(checkBox_teslimedildi_sayi2, "Teslim edildi");
            tool.SetToolTip(checkBox_teslimedildi_sayi3, "Teslim edildi");
            tool.SetToolTip(checkBox_teslimedildi_sayi4, "Teslim edildi");
            tool.SetToolTip(checkBox_teslimedildi_sayi5, "Teslim edildi");
            tool.SetToolTip(checkBox_teslimedildi_sayi6, "Teslim edildi");
        }
        void programi_kullanan_kisi_doldur()
        {
            label14.Text = info.kisi_boss.isim;
        }

        void label_dergi_isim_doldur()
        {
            string[] dergiler = new string[6];
            dergiler = new dao.dergi().bu_yilin_dergileri();
            if (dergiler != null)
            {
                label_sayi1.Text = dergiler[0];
                label_sayi2.Text = dergiler[1];
                label_sayi3.Text = dergiler[2];
                label_sayi4.Text = dergiler[3];
                label_sayi5.Text = dergiler[4];
                label_sayi6.Text = dergiler[5];
            }
            else
            {
                MessageBox.Show("Sistedmen Dergiler Alınamıyor \n TEKRAR DENEYİN");
                this.Close();
                new yönlendirme().Show();
            }
        }

        private void label_sayi1_Click(object sender, EventArgs e)
        {
            if (label_sayi1.BackColor == Color.Green)
            {
                label_sayi1.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(1);
            }
            else label_sayi1.BackColor = Color.Green;
        }

        private void label_sayi2_Click(object sender, EventArgs e)
        {
            if (label_sayi2.BackColor == Color.Green)
            {
                label_sayi2.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(2);
            }
            else label_sayi2.BackColor = Color.Green;
        }

        private void label_sayi3_Click(object sender, EventArgs e)
        {
            if (label_sayi3.BackColor == Color.Green)
            {
                label_sayi3.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(3);
            }
            else label_sayi3.BackColor = Color.Green;
        }

        private void label_sayi4_Click(object sender, EventArgs e)
        {
            if (label_sayi4.BackColor == Color.Green)
            {
                label_sayi4.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(4);
            }
            else label_sayi4.BackColor = Color.Green;
        }

        private void label_sayi5_Click(object sender, EventArgs e)
        {
            if (label_sayi5.BackColor == Color.Green)
            {
                label_sayi5.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(5);
            }
            else label_sayi5.BackColor = Color.Green;
        }

        private void label_sayi6_Click(object sender, EventArgs e)
        {
            if (label_sayi6.BackColor == Color.Green)
            {
                label_sayi6.BackColor = Color.Transparent;
                miktar_fiyat__checkbox_sifirla(6);
            }
            else label_sayi6.BackColor = Color.Green;
        }

        void miktar_fiyat__checkbox_sifirla(int sayi)
        {
            if (sayi == 1)
            {
                txt_fiyat_sayi1.Text = "";
                txt_miktar_sayi1.Text = "";
                checkBox_odendi_sayi1.Checked = false;
                checkBox_teslimedildi_sayi1.Checked = false;
                return;
            }
            else if (sayi == 2)
            {
                txt_fiyat_sayi2.Text = "";
                txt_miktar_sayi2.Text = "";
                checkBox_odendi_sayi2.Checked = false;
                checkBox_teslimedildi_sayi2.Checked = false;
                return;
            }
            else if (sayi == 3)
            {
                txt_fiyat_sayi3.Text = "";
                txt_miktar_sayi3.Text = "";
                checkBox_odendi_sayi3.Checked = false;
                checkBox_teslimedildi_sayi3.Checked = false;
                return;
            }
            else if (sayi == 4)
            {
                txt_fiyat_sayi4.Text = "";
                txt_miktar_sayi4.Text = "";
                checkBox_odendi_sayi4.Checked = false;
                checkBox_teslimedildi_sayi4.Checked = false;
                return;
            }
            else if (sayi == 5)
            {
                txt_fiyat_sayi5.Text = "";
                txt_miktar_sayi5.Text = "";
                checkBox_odendi_sayi5.Checked = false;
                checkBox_teslimedildi_sayi5.Checked = false;
                return;
            }
            else if (sayi == 6)
            {
                txt_fiyat_sayi6.Text = "";
                txt_miktar_sayi6.Text = "";
                checkBox_odendi_sayi6.Checked = false;
                checkBox_teslimedildi_sayi6.Checked = false;
                return;
            }
        }

        private void tumunu_teslim_et_Click(object sender, EventArgs e)
        {
            checkbox_teslim_et();
        }

        private void tumunu_ode_Click(object sender, EventArgs e)
        {
            checkbox_tumunu_ode();
        }

        /// <summary>
        /// ///////////////////////////////////////
        /// </summary
        private void btn_tamamla_Click(object sender, EventArgs e)
        {
            if (kisi_id>0)
            {
                string abone_olundu = "";

                if (label_sayi1.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi1.Text.Trim(' ', '\n') != "" && txt_miktar_sayi1.Text.Trim(' ', '\n') != "")
                    {
                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi1.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi1.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi1.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi1.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi1.Checked;
                            abone_Yap.kisi_id = kisi_id;
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 1 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi1.Text; }
                        }
                        catch (Exception hata)
                        {
                         //   MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 1 eklenirken hata olustu");
                        }
                    }
                    else MessageBox.Show("Sayı 1 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi1.Text);

                if (label_sayi2.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi2.Text.Trim(' ', '\n') != "" && txt_miktar_sayi2.Text.Trim(' ', '\n') != "")
                    {
                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi2.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi2.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi2.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi2.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi2.Checked;
                            abone_Yap.kisi_id = kisi_id;
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 2 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi2.Text; }
                        }
                        catch (Exception hata)
                        {
                          //  MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 2 eklenirken hata olustu");
                        }
                    }
                    else MessageBox.Show("Sayı 2 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi2.Text);


                if (label_sayi3.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi3.Text.Trim(' ', '\n') != "" && txt_miktar_sayi3.Text.Trim(' ', '\n') != "")
                    {

                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi3.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi3.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi3.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi3.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi3.Checked;
                            abone_Yap.kisi_id = kisi_id;
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 3 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi3.Text; }
                        }
                        catch (Exception hata)
                        {
                         //   MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 3 eklenirken hata olustu");
                        }


                    }
                    else MessageBox.Show("Sayı 3 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi3.Text);


                if (label_sayi4.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi4.Text.Trim(' ', '\n') != "" && txt_miktar_sayi4.Text.Trim(' ', '\n') != "")
                    {

                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi4.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi4.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi4.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi4.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi4.Checked;
                            abone_Yap.kisi_id = kisi_id;
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 4 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi4.Text; }
                        }
                        catch (Exception hata)
                        {
                          //  MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 4 eklenirken hata olustu");
                        }


                    }
                    else MessageBox.Show("Sayı 4 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi4.Text);


                if (label_sayi5.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi5.Text.Trim(' ', '\n') != "" && txt_miktar_sayi5.Text.Trim(' ', '\n') != "")
                    {
                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi5.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi5.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi5.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi5.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi5.Checked;
                            abone_Yap.kisi_id = kisi_id;  
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 5 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi5.Text; }
                        }
                        catch (Exception hata)
                        {
                          //  MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 5 eklenirken hata olustu");
                        }
                    }
                    else MessageBox.Show("Sayı 5 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi5.Text);

                if (label_sayi6.BackColor == Color.Green)
                {
                    if (txt_fiyat_sayi6.Text.Trim(' ', '\n') != "" && txt_miktar_sayi6.Text.Trim(' ', '\n') != "")
                    {
                        try
                        {
                            info.abone_yap abone_Yap = new info.abone_yap();
                            abone_Yap.dergi_isim = label_sayi6.Text;
                            abone_Yap.fiyat = Convert.ToInt32(txt_fiyat_sayi6.Text.Trim(' ', '\n'));
                            abone_Yap.odendi = checkBox_odendi_sayi6.Checked;
                            abone_Yap.kac_tane = Convert.ToInt32(txt_miktar_sayi6.Text.Trim(' ', '\n'));
                            abone_Yap.teslim_edildi = checkBox_teslimedildi_sayi6.Checked;
                            abone_Yap.kisi_id = kisi_id;
                            if (!new dao.dergi().dergi_abone_yap(abone_Yap))
                            {
                                MessageBox.Show("sayi 6 eklenirken hata olustu");
                            }
                            else { abone_olundu = abone_olundu + "\n" + label_sayi6.Text; }
                        }
                        catch (Exception hata)
                        {
                          //  MessageBox.Show(hata.Message);
                            MessageBox.Show("sayi 6 eklenirken hata olustu");
                        }
                    }
                    else MessageBox.Show("Sayı 6 için Fiyat ve miktar kısmı boş olamaz ");
                }
                else new dao.dergi().dergi_abone_sil(kisi_id, label_sayi6.Text);

                MessageBox.Show("abone olunan dergiler \n" + abone_olundu);
                this.Close();

                new dao.kasa().update();

                new yönlendirme().Show();

            }
            else MessageBox.Show("KİŞİ SEÇİLEMEDİ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new yönlendirme().Show();
        }
    }
}
