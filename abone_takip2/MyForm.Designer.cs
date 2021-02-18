namespace abone_takip2
{
    partial class MyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_yeni_kasa = new System.Windows.Forms.Button();
            this.btn_yeni_sayi_ekle = new System.Windows.Forms.Button();
            this.btn_database_temizle = new System.Windows.Forms.Button();
            this.btn_onceki_sayilari_sil = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.txt_kasa_yil = new System.Windows.Forms.TextBox();
            this.btn_onceki_kasalari_sil = new System.Windows.Forms.Button();
            this.btn_kisileri_temizle = new System.Windows.Forms.Button();
            this.txt_yeni_dergiler = new System.Windows.Forms.TextBox();
            this.btn_abone_islemleri_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_yeni_kasa
            // 
            this.btn_yeni_kasa.Location = new System.Drawing.Point(23, 126);
            this.btn_yeni_kasa.Name = "btn_yeni_kasa";
            this.btn_yeni_kasa.Size = new System.Drawing.Size(179, 127);
            this.btn_yeni_kasa.TabIndex = 0;
            this.btn_yeni_kasa.Text = "Yeni Yıl Kasa";
            this.btn_yeni_kasa.UseVisualStyleBackColor = true;
            this.btn_yeni_kasa.Click += new System.EventHandler(this.btn_yeni_kasa_Click);
            // 
            // btn_yeni_sayi_ekle
            // 
            this.btn_yeni_sayi_ekle.Location = new System.Drawing.Point(231, 126);
            this.btn_yeni_sayi_ekle.Name = "btn_yeni_sayi_ekle";
            this.btn_yeni_sayi_ekle.Size = new System.Drawing.Size(209, 127);
            this.btn_yeni_sayi_ekle.TabIndex = 1;
            this.btn_yeni_sayi_ekle.Text = "Yeni Yıl Sayılarını Ekle";
            this.btn_yeni_sayi_ekle.UseVisualStyleBackColor = true;
            this.btn_yeni_sayi_ekle.Click += new System.EventHandler(this.btn_yeni_sayi_ekle_Click);
            // 
            // btn_database_temizle
            // 
            this.btn_database_temizle.Location = new System.Drawing.Point(479, 12);
            this.btn_database_temizle.Name = "btn_database_temizle";
            this.btn_database_temizle.Size = new System.Drawing.Size(200, 143);
            this.btn_database_temizle.TabIndex = 2;
            this.btn_database_temizle.Text = "DataBase\'i Temizle";
            this.btn_database_temizle.UseVisualStyleBackColor = true;
            this.btn_database_temizle.Click += new System.EventHandler(this.btn_database_temizle_Click);
            // 
            // btn_onceki_sayilari_sil
            // 
            this.btn_onceki_sayilari_sil.Location = new System.Drawing.Point(231, 12);
            this.btn_onceki_sayilari_sil.Name = "btn_onceki_sayilari_sil";
            this.btn_onceki_sayilari_sil.Size = new System.Drawing.Size(206, 108);
            this.btn_onceki_sayilari_sil.TabIndex = 3;
            this.btn_onceki_sayilari_sil.Text = "Eski Sayıları Sıfırla";
            this.btn_onceki_sayilari_sil.UseVisualStyleBackColor = true;
            this.btn_onceki_sayilari_sil.Click += new System.EventHandler(this.btn_onceki_sayilari_sil_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.Location = new System.Drawing.Point(728, 335);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(75, 55);
            this.btn_esc.TabIndex = 4;
            this.btn_esc.Text = "esc";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // txt_kasa_yil
            // 
            this.txt_kasa_yil.Location = new System.Drawing.Point(61, 212);
            this.txt_kasa_yil.Name = "txt_kasa_yil";
            this.txt_kasa_yil.Size = new System.Drawing.Size(100, 20);
            this.txt_kasa_yil.TabIndex = 5;
            // 
            // btn_onceki_kasalari_sil
            // 
            this.btn_onceki_kasalari_sil.Location = new System.Drawing.Point(23, 12);
            this.btn_onceki_kasalari_sil.Name = "btn_onceki_kasalari_sil";
            this.btn_onceki_kasalari_sil.Size = new System.Drawing.Size(179, 108);
            this.btn_onceki_kasalari_sil.TabIndex = 6;
            this.btn_onceki_kasalari_sil.Text = "Onceki Kasayı Sil";
            this.btn_onceki_kasalari_sil.UseVisualStyleBackColor = true;
            this.btn_onceki_kasalari_sil.Click += new System.EventHandler(this.btn_onceki_kasalari_sil_Click);
            // 
            // btn_kisileri_temizle
            // 
            this.btn_kisileri_temizle.Location = new System.Drawing.Point(231, 563);
            this.btn_kisileri_temizle.Name = "btn_kisileri_temizle";
            this.btn_kisileri_temizle.Size = new System.Drawing.Size(179, 133);
            this.btn_kisileri_temizle.TabIndex = 7;
            this.btn_kisileri_temizle.Text = "Kişileri Temizle";
            this.btn_kisileri_temizle.UseVisualStyleBackColor = true;
            this.btn_kisileri_temizle.Click += new System.EventHandler(this.btn_kisileri_temizle_Click);
            // 
            // txt_yeni_dergiler
            // 
            this.txt_yeni_dergiler.Location = new System.Drawing.Point(284, 212);
            this.txt_yeni_dergiler.Name = "txt_yeni_dergiler";
            this.txt_yeni_dergiler.Size = new System.Drawing.Size(100, 20);
            this.txt_yeni_dergiler.TabIndex = 8;
            // 
            // btn_abone_islemleri_sil
            // 
            this.btn_abone_islemleri_sil.Location = new System.Drawing.Point(23, 563);
            this.btn_abone_islemleri_sil.Name = "btn_abone_islemleri_sil";
            this.btn_abone_islemleri_sil.Size = new System.Drawing.Size(179, 133);
            this.btn_abone_islemleri_sil.TabIndex = 9;
            this.btn_abone_islemleri_sil.Text = "Abone İşlemleri Sil";
            this.btn_abone_islemleri_sil.UseVisualStyleBackColor = true;
            this.btn_abone_islemleri_sil.Click += new System.EventHandler(this.btn_abone_islemleri_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "*4 haneli yıl giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "*4 haneli yıl giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "*önceki kasalari pasif yapar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(231, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 230);
            this.panel1.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "*4 haneli yıl giriniz";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(24, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 20);
            this.textBox7.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "her sayi icin miktar gir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Yeni yıl sayılarını ekle \\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "eski sayilari sifirla";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "depoyu olustur";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(108, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "sayi 6 :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 117);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "sayi 5 : ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "sayi 4 :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "sayi 3 : ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "sayi 2 :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "sayi 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(55, 20);
            this.textBox1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 108);
            this.button2.TabIndex = 14;
            this.button2.Text = "Onceki Kasalari Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 133);
            this.button3.TabIndex = 15;
            this.button3.Text = "Kişiler Hariç Sıfırla";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 125);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 161);
            this.button4.TabIndex = 16;
            this.button4.Text = "YENİ YIL KAYITLARI OLUŞTUR      kisiler silinmeden    ----  hersey silinecek";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(48, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 38);
            this.textBox8.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(479, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 306);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "*4 haneli yıl giriniz";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_abone_islemleri_sil);
            this.Controls.Add(this.txt_yeni_dergiler);
            this.Controls.Add(this.btn_kisileri_temizle);
            this.Controls.Add(this.btn_onceki_kasalari_sil);
            this.Controls.Add(this.txt_kasa_yil);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.btn_onceki_sayilari_sil);
            this.Controls.Add(this.btn_database_temizle);
            this.Controls.Add(this.btn_yeni_sayi_ekle);
            this.Controls.Add(this.btn_yeni_kasa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_yeni_kasa;
        private System.Windows.Forms.Button btn_yeni_sayi_ekle;
        private System.Windows.Forms.Button btn_database_temizle;
        private System.Windows.Forms.Button btn_onceki_sayilari_sil;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.TextBox txt_kasa_yil;
        private System.Windows.Forms.Button btn_onceki_kasalari_sil;
        private System.Windows.Forms.Button btn_kisileri_temizle;
        private System.Windows.Forms.TextBox txt_yeni_dergiler;
        private System.Windows.Forms.Button btn_abone_islemleri_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
    }
}