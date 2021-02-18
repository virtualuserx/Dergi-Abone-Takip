namespace abone_takip2
{
    partial class dergi_takip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_teslimedilmedi = new System.Windows.Forms.RadioButton();
            this.radioButton_teslimedildi = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_odenmedi = new System.Windows.Forms.RadioButton();
            this.radioButton_odendi = new System.Windows.Forms.RadioButton();
            this.dataGridView_dergi_takip = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_teslim_edildi_orani = new System.Windows.Forms.Label();
            this.label_odendi_orani = new System.Windows.Forms.Label();
            this.groupBox_sayilar = new System.Windows.Forms.GroupBox();
            this.radioButton_sayi_tumu = new System.Windows.Forms.RadioButton();
            this.label_yil = new System.Windows.Forms.Label();
            this.radioButton_sayi6 = new System.Windows.Forms.RadioButton();
            this.radioButton_sayi5 = new System.Windows.Forms.RadioButton();
            this.radioButton_sayi4 = new System.Windows.Forms.RadioButton();
            this.radioButton_sayi3 = new System.Windows.Forms.RadioButton();
            this.radioButton_sayi2 = new System.Windows.Forms.RadioButton();
            this.radioButton_sayi1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dergi_takip)).BeginInit();
            this.groupBox_sayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_teslimedilmedi);
            this.groupBox1.Controls.Add(this.radioButton_teslimedildi);
            this.groupBox1.Location = new System.Drawing.Point(214, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 39);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton_teslimedilmedi
            // 
            this.radioButton_teslimedilmedi.AutoSize = true;
            this.radioButton_teslimedilmedi.Location = new System.Drawing.Point(115, 16);
            this.radioButton_teslimedilmedi.Name = "radioButton_teslimedilmedi";
            this.radioButton_teslimedilmedi.Size = new System.Drawing.Size(118, 17);
            this.radioButton_teslimedilmedi.TabIndex = 1;
            this.radioButton_teslimedilmedi.TabStop = true;
            this.radioButton_teslimedilmedi.Text = "TESLİM EDİLMEDİ";
            this.radioButton_teslimedilmedi.UseVisualStyleBackColor = true;
            // 
            // radioButton_teslimedildi
            // 
            this.radioButton_teslimedildi.AutoSize = true;
            this.radioButton_teslimedildi.Location = new System.Drawing.Point(7, 16);
            this.radioButton_teslimedildi.Name = "radioButton_teslimedildi";
            this.radioButton_teslimedildi.Size = new System.Drawing.Size(102, 17);
            this.radioButton_teslimedildi.TabIndex = 0;
            this.radioButton_teslimedildi.TabStop = true;
            this.radioButton_teslimedildi.Text = "TESLİM EDİLDİ";
            this.radioButton_teslimedildi.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_odenmedi);
            this.groupBox2.Controls.Add(this.radioButton_odendi);
            this.groupBox2.Location = new System.Drawing.Point(489, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 39);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton_odenmedi
            // 
            this.radioButton_odenmedi.AutoSize = true;
            this.radioButton_odenmedi.Location = new System.Drawing.Point(120, 16);
            this.radioButton_odenmedi.Name = "radioButton_odenmedi";
            this.radioButton_odenmedi.Size = new System.Drawing.Size(83, 17);
            this.radioButton_odenmedi.TabIndex = 1;
            this.radioButton_odenmedi.TabStop = true;
            this.radioButton_odenmedi.Text = "ÖDENMEDİ";
            this.radioButton_odenmedi.UseVisualStyleBackColor = true;
            // 
            // radioButton_odendi
            // 
            this.radioButton_odendi.AutoSize = true;
            this.radioButton_odendi.Location = new System.Drawing.Point(7, 16);
            this.radioButton_odendi.Name = "radioButton_odendi";
            this.radioButton_odendi.Size = new System.Drawing.Size(67, 17);
            this.radioButton_odendi.TabIndex = 0;
            this.radioButton_odendi.TabStop = true;
            this.radioButton_odendi.Text = "ÖDENDİ";
            this.radioButton_odendi.UseVisualStyleBackColor = true;
            // 
            // dataGridView_dergi_takip
            // 
            this.dataGridView_dergi_takip.AllowUserToAddRows = false;
            this.dataGridView_dergi_takip.AllowUserToDeleteRows = false;
            this.dataGridView_dergi_takip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dergi_takip.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_dergi_takip.Location = new System.Drawing.Point(98, 115);
            this.dataGridView_dergi_takip.Name = "dataGridView_dergi_takip";
            this.dataGridView_dergi_takip.ReadOnly = true;
            this.dataGridView_dergi_takip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_dergi_takip.Size = new System.Drawing.Size(647, 388);
            this.dataGridView_dergi_takip.TabIndex = 3;
            this.dataGridView_dergi_takip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dergi_takip_CellContentClick);
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Pink;
            this.btn_listele.Font = new System.Drawing.Font("Impact", 12F);
            this.btn_listele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_listele.Location = new System.Drawing.Point(719, 47);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(135, 53);
            this.btn_listele.TabIndex = 12;
            this.btn_listele.Text = "L İ S T E L E";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "TESLİM EDİLDİ =>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ÖDENDİ =>";
            // 
            // label_teslim_edildi_orani
            // 
            this.label_teslim_edildi_orani.AutoSize = true;
            this.label_teslim_edildi_orani.Location = new System.Drawing.Point(117, 12);
            this.label_teslim_edildi_orani.Name = "label_teslim_edildi_orani";
            this.label_teslim_edildi_orani.Size = new System.Drawing.Size(42, 13);
            this.label_teslim_edildi_orani.TabIndex = 20;
            this.label_teslim_edildi_orani.Text = "00/000";
            // 
            // label_odendi_orani
            // 
            this.label_odendi_orani.AutoSize = true;
            this.label_odendi_orani.Location = new System.Drawing.Point(117, 53);
            this.label_odendi_orani.Name = "label_odendi_orani";
            this.label_odendi_orani.Size = new System.Drawing.Size(42, 13);
            this.label_odendi_orani.TabIndex = 21;
            this.label_odendi_orani.Text = "00/000";
            // 
            // groupBox_sayilar
            // 
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi_tumu);
            this.groupBox_sayilar.Controls.Add(this.label_yil);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi6);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi5);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi4);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi3);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi2);
            this.groupBox_sayilar.Controls.Add(this.radioButton_sayi1);
            this.groupBox_sayilar.Location = new System.Drawing.Point(214, 57);
            this.groupBox_sayilar.Name = "groupBox_sayilar";
            this.groupBox_sayilar.Size = new System.Drawing.Size(492, 43);
            this.groupBox_sayilar.TabIndex = 22;
            this.groupBox_sayilar.TabStop = false;
            this.groupBox_sayilar.Text = "sayilar";
            // 
            // radioButton_sayi_tumu
            // 
            this.radioButton_sayi_tumu.AutoSize = true;
            this.radioButton_sayi_tumu.Location = new System.Drawing.Point(423, 17);
            this.radioButton_sayi_tumu.Name = "radioButton_sayi_tumu";
            this.radioButton_sayi_tumu.Size = new System.Drawing.Size(48, 17);
            this.radioButton_sayi_tumu.TabIndex = 7;
            this.radioButton_sayi_tumu.TabStop = true;
            this.radioButton_sayi_tumu.Text = "tümü";
            this.radioButton_sayi_tumu.UseVisualStyleBackColor = true;
            // 
            // label_yil
            // 
            this.label_yil.AutoSize = true;
            this.label_yil.Location = new System.Drawing.Point(6, 17);
            this.label_yil.Name = "label_yil";
            this.label_yil.Size = new System.Drawing.Size(23, 13);
            this.label_yil.TabIndex = 6;
            this.label_yil.Text = "YIL";
            // 
            // radioButton_sayi6
            // 
            this.radioButton_sayi6.AutoSize = true;
            this.radioButton_sayi6.Location = new System.Drawing.Point(364, 17);
            this.radioButton_sayi6.Name = "radioButton_sayi6";
            this.radioButton_sayi6.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi6.TabIndex = 5;
            this.radioButton_sayi6.TabStop = true;
            this.radioButton_sayi6.Text = "06";
            this.radioButton_sayi6.UseVisualStyleBackColor = true;
            // 
            // radioButton_sayi5
            // 
            this.radioButton_sayi5.AutoSize = true;
            this.radioButton_sayi5.Location = new System.Drawing.Point(305, 15);
            this.radioButton_sayi5.Name = "radioButton_sayi5";
            this.radioButton_sayi5.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi5.TabIndex = 4;
            this.radioButton_sayi5.TabStop = true;
            this.radioButton_sayi5.Text = "05";
            this.radioButton_sayi5.UseVisualStyleBackColor = true;
            // 
            // radioButton_sayi4
            // 
            this.radioButton_sayi4.AutoSize = true;
            this.radioButton_sayi4.Location = new System.Drawing.Point(242, 17);
            this.radioButton_sayi4.Name = "radioButton_sayi4";
            this.radioButton_sayi4.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi4.TabIndex = 3;
            this.radioButton_sayi4.TabStop = true;
            this.radioButton_sayi4.Text = "04";
            this.radioButton_sayi4.UseVisualStyleBackColor = true;
            // 
            // radioButton_sayi3
            // 
            this.radioButton_sayi3.AutoSize = true;
            this.radioButton_sayi3.Location = new System.Drawing.Point(189, 15);
            this.radioButton_sayi3.Name = "radioButton_sayi3";
            this.radioButton_sayi3.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi3.TabIndex = 2;
            this.radioButton_sayi3.TabStop = true;
            this.radioButton_sayi3.Text = "03";
            this.radioButton_sayi3.UseVisualStyleBackColor = true;
            // 
            // radioButton_sayi2
            // 
            this.radioButton_sayi2.AutoSize = true;
            this.radioButton_sayi2.Location = new System.Drawing.Point(128, 15);
            this.radioButton_sayi2.Name = "radioButton_sayi2";
            this.radioButton_sayi2.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi2.TabIndex = 1;
            this.radioButton_sayi2.TabStop = true;
            this.radioButton_sayi2.Text = "02";
            this.radioButton_sayi2.UseVisualStyleBackColor = true;
            // 
            // radioButton_sayi1
            // 
            this.radioButton_sayi1.AutoSize = true;
            this.radioButton_sayi1.Location = new System.Drawing.Point(65, 15);
            this.radioButton_sayi1.Name = "radioButton_sayi1";
            this.radioButton_sayi1.Size = new System.Drawing.Size(37, 17);
            this.radioButton_sayi1.TabIndex = 0;
            this.radioButton_sayi1.TabStop = true;
            this.radioButton_sayi1.Text = "01";
            this.radioButton_sayi1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(819, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 41);
            this.button1.TabIndex = 117;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dergi_takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox_sayilar);
            this.Controls.Add(this.label_odendi_orani);
            this.Controls.Add(this.label_teslim_edildi_orani);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGridView_dergi_takip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dergi_takip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dergi_takip";
            this.Load += new System.EventHandler(this.dergi_takip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dergi_takip)).EndInit();
            this.groupBox_sayilar.ResumeLayout(false);
            this.groupBox_sayilar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_teslimedilmedi;
        private System.Windows.Forms.RadioButton radioButton_teslimedildi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_odenmedi;
        private System.Windows.Forms.RadioButton radioButton_odendi;
        private System.Windows.Forms.DataGridView dataGridView_dergi_takip;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_teslim_edildi_orani;
        private System.Windows.Forms.Label label_odendi_orani;
        private System.Windows.Forms.GroupBox groupBox_sayilar;
        private System.Windows.Forms.RadioButton radioButton_sayi_tumu;
        private System.Windows.Forms.Label label_yil;
        private System.Windows.Forms.RadioButton radioButton_sayi6;
        private System.Windows.Forms.RadioButton radioButton_sayi5;
        private System.Windows.Forms.RadioButton radioButton_sayi4;
        private System.Windows.Forms.RadioButton radioButton_sayi3;
        private System.Windows.Forms.RadioButton radioButton_sayi2;
        private System.Windows.Forms.RadioButton radioButton_sayi1;
        private System.Windows.Forms.Button button1;
    }
}