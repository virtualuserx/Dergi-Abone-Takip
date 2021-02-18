namespace abone_takip2
{
    partial class kisi_ekle
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
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.cb_il = new System.Windows.Forms.ComboBox();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.radioButton_Patron = new System.Windows.Forms.RadioButton();
            this.radioButton_Normal = new System.Windows.Forms.RadioButton();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_kisiekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ilekle = new System.Windows.Forms.TextBox();
            this.btn_ilekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(35, 53);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(121, 20);
            this.txt_tc.TabIndex = 0;
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(203, 84);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(188, 20);
            this.txt_isim.TabIndex = 1;
            // 
            // cb_il
            // 
            this.cb_il.FormattingEnabled = true;
            this.cb_il.Location = new System.Drawing.Point(35, 188);
            this.cb_il.Name = "cb_il";
            this.cb_il.Size = new System.Drawing.Size(121, 21);
            this.cb_il.TabIndex = 2;
            this.cb_il.SelectedIndexChanged += new System.EventHandler(this.cb_il_SelectedIndexChanged);
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(204, 154);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(187, 67);
            this.txt_adress.TabIndex = 3;
            // 
            // radioButton_Patron
            // 
            this.radioButton_Patron.AutoSize = true;
            this.radioButton_Patron.Location = new System.Drawing.Point(467, 83);
            this.radioButton_Patron.Name = "radioButton_Patron";
            this.radioButton_Patron.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Patron.TabIndex = 4;
            this.radioButton_Patron.TabStop = true;
            this.radioButton_Patron.Text = "Patron";
            this.radioButton_Patron.UseVisualStyleBackColor = true;
            this.radioButton_Patron.CheckedChanged += new System.EventHandler(this.radioButton_Patron_CheckedChanged);
            // 
            // radioButton_Normal
            // 
            this.radioButton_Normal.AutoSize = true;
            this.radioButton_Normal.Location = new System.Drawing.Point(582, 83);
            this.radioButton_Normal.Name = "radioButton_Normal";
            this.radioButton_Normal.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Normal.TabIndex = 5;
            this.radioButton_Normal.TabStop = true;
            this.radioButton_Normal.Text = "Normal";
            this.radioButton_Normal.UseVisualStyleBackColor = true;
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(508, 120);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(121, 20);
            this.txt_parola.TabIndex = 6;
            this.txt_parola.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parola";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ADRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "İL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "İSİM SOY İSİM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TC";
            // 
            // btn_kisiekle
            // 
            this.btn_kisiekle.BackColor = System.Drawing.Color.HotPink;
            this.btn_kisiekle.Font = new System.Drawing.Font("Impact", 18F);
            this.btn_kisiekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_kisiekle.Location = new System.Drawing.Point(438, 154);
            this.btn_kisiekle.Name = "btn_kisiekle";
            this.btn_kisiekle.Size = new System.Drawing.Size(229, 67);
            this.btn_kisiekle.TabIndex = 12;
            this.btn_kisiekle.Text = "K i s i    E k l e";
            this.btn_kisiekle.UseVisualStyleBackColor = false;
            this.btn_kisiekle.Click += new System.EventHandler(this.btn_kisiekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "--";
            // 
            // txt_ilekle
            // 
            this.txt_ilekle.Location = new System.Drawing.Point(35, 189);
            this.txt_ilekle.Name = "txt_ilekle";
            this.txt_ilekle.Size = new System.Drawing.Size(121, 20);
            this.txt_ilekle.TabIndex = 15;
            this.txt_ilekle.Visible = false;
            // 
            // btn_ilekle
            // 
            this.btn_ilekle.Location = new System.Drawing.Point(162, 188);
            this.btn_ilekle.Name = "btn_ilekle";
            this.btn_ilekle.Size = new System.Drawing.Size(36, 21);
            this.btn_ilekle.TabIndex = 16;
            this.btn_ilekle.Text = "+";
            this.btn_ilekle.UseVisualStyleBackColor = true;
            this.btn_ilekle.Visible = false;
            this.btn_ilekle.Click += new System.EventHandler(this.btn_ilekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "TELEFON";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(34, 96);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(121, 20);
            this.txt_telefon.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.No;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(692, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 41);
            this.button2.TabIndex = 38;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kisi_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 278);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.btn_ilekle);
            this.Controls.Add(this.txt_ilekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_kisiekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.radioButton_Normal);
            this.Controls.Add(this.radioButton_Patron);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.cb_il);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_tc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kisi_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kisi_ekle";
            this.Load += new System.EventHandler(this.kisi_ekle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.ComboBox cb_il;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.RadioButton radioButton_Patron;
        private System.Windows.Forms.RadioButton radioButton_Normal;
        private System.Windows.Forms.TextBox txt_parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_kisiekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ilekle;
        private System.Windows.Forms.Button btn_ilekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Button button2;
    }
}