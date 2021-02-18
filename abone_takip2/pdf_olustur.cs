using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abone_takip2
{


    public partial class pdf_olustur : Form
    {
       
            


        string sayi_yil = "";
        string sayi_no = "";
        string adet = "";
        string fiyat = "";
        bool odendi = false;
        info.kisi kisi = new info.kisi();
        public pdf_olustur(info.kisi kisi, string sayi, string adet, string fiyat, bool odendi)
        {
            this.kisi = kisi;
            this.sayi_yil = sayi.Split('_')[0];
            this.sayi_no = sayi.Split('_')[1];
            this.adet = adet;
            this.fiyat = fiyat;
            this.odendi = odendi;


            InitializeComponent();
        }

        private void pdf_olustur_Load(object sender, EventArgs e)
        {
            kisi_bilgi_doldur();
            sayi_hakkinda_bilgi_doldur();
        }

        void kisi_bilgi_doldur()
        {
            label_isim.Text = kisi.isim;
            label_tc.Text = kisi.tc;
            label_telefon.Text = kisi.telefon;
            label_adres.Text = kisi.adress;
            label_il.Text = kisi.il;
        }

        void sayi_hakkinda_bilgi_doldur()
        {
            label_sayi.Text = sayi_yil + " 'n " + sayi_no + ". SAYISI";
            label_adet.Text = adet + " Adet";


        }

        private void label_fiyat_Click(object sender, EventArgs e)
        {
            
        }

        private void checkbox_fiyat_bilgi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_fiyat_bilgi.Checked) { if (!odendi) label_fiyat_odendi_odenecek.Text = "Ödenecek Tutar"; else label_fiyat_odendi_odenecek.Text = "Ödenen Tutar"; label_fiyat.Text = fiyat + " TL"; }
            else { label_fiyat_odendi_odenecek.Text = ""; label_fiyat.Text = ""; }
        }

        private string dosya_yolu()
        {
            string dosya_yoluu = "";
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.CheckFileExists = true; //dosya kontrol
            dialog.Multiselect = false;//çoklu seçimi iptal et.



            dosya_yoluu = dialog.FileName[0].ToString();

            //dosyayı okuma modunda açıyoruz
            FileStream fileStream = new FileStream(dosya_yoluu, FileMode.Create, FileAccess.Write);
            //dosyadan satır satır okuyup textBox içine yazıdırıyoruz

            fileStream.Close();

            return dosya_yoluu;
        }

        private void btn_pdf_olustur_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
             btn_pdf_olustur.Visible = false;
            panel2.Visible = false;
             Bitmap bitmap = new Bitmap(this.Width,this.Height);
             DrawToBitmap(bitmap, new System.Drawing.Rectangle(0,0, bitmap.Width, bitmap.Height));
             string adress =kisi.tc+"_"+kisi.isim+"_"+sayi_yil+"_"+sayi_no;
             bitmap.Save($"B:\\{adress}.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            btn_pdf_olustur.Visible = true;
            panel2.Visible = true;
            PageSize size = new PageSize();
            

            System.Drawing.Image image = System.Drawing.Image.FromFile("B:\\abfddsc1efrg.jpeg");
            Document doc = new Document(new iTextSharp.text.Rectangle(0, 0, bitmap.Width+70, bitmap.Height+70));
            PdfWriter.GetInstance(doc, new FileStream($"B:\\{ adress }.pdf", FileMode.Create));
            doc.Open();
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Jpeg);
            doc.Add(pdfImage);
            doc.Close();
            MessageBox.Show(dosya_yolu());



            /*const string i1Path = @"c:\my\i1.jpg";
            const string i2Path = @"c:\my\i2.jpg";

            var i = Image.FromFile(i1Path);

            var i2 = new Bitmap(i);
            i2.Save(i2Path, System.Drawing.Imaging.ImageFormat.Jpeg);
            */

        }
    }
}
