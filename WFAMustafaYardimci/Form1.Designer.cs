namespace WFAMustafaYardimci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEbatlar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.rbInceKenar = new System.Windows.Forms.RadioButton();
            this.rbKalinKenar = new System.Windows.Forms.RadioButton();
            this.grpMalzemeler = new System.Windows.Forms.GroupBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnSiparisOnay = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGuncelTutar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpMalzemeler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(448, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizza Sipariş Ekranı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(2, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1174, 35);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(2, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 577);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Location = new System.Drawing.Point(1159, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 580);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ebatlar:";
            // 
            // cbEbatlar
            // 
            this.cbEbatlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEbatlar.FormattingEnabled = true;
            this.cbEbatlar.Location = new System.Drawing.Point(111, 85);
            this.cbEbatlar.Name = "cbEbatlar";
            this.cbEbatlar.Size = new System.Drawing.Size(246, 28);
            this.cbEbatlar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pizzalar:";
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.ItemHeight = 20;
            this.lstPizzalar.Location = new System.Drawing.Point(115, 131);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(246, 144);
            this.lstPizzalar.TabIndex = 4;
            // 
            // rbInceKenar
            // 
            this.rbInceKenar.AutoSize = true;
            this.rbInceKenar.Checked = true;
            this.rbInceKenar.Location = new System.Drawing.Point(111, 278);
            this.rbInceKenar.Name = "rbInceKenar";
            this.rbInceKenar.Size = new System.Drawing.Size(111, 24);
            this.rbInceKenar.TabIndex = 5;
            this.rbInceKenar.TabStop = true;
            this.rbInceKenar.Text = "İnce Kenar";
            this.rbInceKenar.UseVisualStyleBackColor = true;
            // 
            // rbKalinKenar
            // 
            this.rbKalinKenar.AutoSize = true;
            this.rbKalinKenar.Location = new System.Drawing.Point(243, 278);
            this.rbKalinKenar.Name = "rbKalinKenar";
            this.rbKalinKenar.Size = new System.Drawing.Size(114, 24);
            this.rbKalinKenar.TabIndex = 5;
            this.rbKalinKenar.Text = "Kalın Kenar";
            this.rbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // grpMalzemeler
            // 
            this.grpMalzemeler.Controls.Add(this.checkBox10);
            this.grpMalzemeler.Controls.Add(this.checkBox8);
            this.grpMalzemeler.Controls.Add(this.checkBox6);
            this.grpMalzemeler.Controls.Add(this.checkBox4);
            this.grpMalzemeler.Controls.Add(this.checkBox2);
            this.grpMalzemeler.Controls.Add(this.checkBox9);
            this.grpMalzemeler.Controls.Add(this.checkBox7);
            this.grpMalzemeler.Controls.Add(this.checkBox5);
            this.grpMalzemeler.Controls.Add(this.checkBox3);
            this.grpMalzemeler.Controls.Add(this.checkBox1);
            this.grpMalzemeler.Location = new System.Drawing.Point(111, 325);
            this.grpMalzemeler.Name = "grpMalzemeler";
            this.grpMalzemeler.Size = new System.Drawing.Size(246, 177);
            this.grpMalzemeler.TabIndex = 6;
            this.grpMalzemeler.TabStop = false;
            this.grpMalzemeler.Text = "Malzemeler";
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(147, 145);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(78, 24);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Tag = "0,15";
            this.checkBox10.Text = "Peynir";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(147, 115);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(104, 24);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "0,15";
            this.checkBox8.Text = "Ton Balığı";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(147, 85);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(85, 24);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "0,15";
            this.checkBox6.Text = "Mantar";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(147, 55);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 24);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "0,15";
            this.checkBox4.Text = "Sucuk";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(147, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 24);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0,15";
            this.checkBox2.Text = "Salam";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(6, 145);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(78, 24);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Tag = "0,15";
            this.checkBox9.Text = "Zeytin";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 115);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(89, 24);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "0,15";
            this.checkBox7.Text = "Ançuez";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 85);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 24);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0,15";
            this.checkBox5.Text = "Mısır";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 24);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "0,15";
            this.checkBox3.Text = "Sosis";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0,15";
            this.checkBox1.Text = "Dana Jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adet :";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(164, 558);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 26);
            this.txtAdet.TabIndex = 7;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(290, 558);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(129, 29);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(506, 561);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(100, 26);
            this.txtTutar.TabIndex = 10;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(635, 549);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(243, 38);
            this.btnSepeteEkle.TabIndex = 11;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnSiparisOnay
            // 
            this.btnSiparisOnay.Location = new System.Drawing.Point(921, 549);
            this.btnSiparisOnay.Name = "btnSiparisOnay";
            this.btnSiparisOnay.Size = new System.Drawing.Size(232, 38);
            this.btnSiparisOnay.TabIndex = 12;
            this.btnSiparisOnay.Text = "Sipariş Onay";
            this.btnSiparisOnay.UseVisualStyleBackColor = true;
            this.btnSiparisOnay.Click += new System.EventHandler(this.btnSiparisOnay_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 20;
            this.lstSiparisler.Location = new System.Drawing.Point(400, 85);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(753, 404);
            this.lstSiparisler.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(917, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Toplam Tutar:";
            // 
            // lblGuncelTutar
            // 
            this.lblGuncelTutar.AutoSize = true;
            this.lblGuncelTutar.Location = new System.Drawing.Point(1029, 506);
            this.lblGuncelTutar.Name = "lblGuncelTutar";
            this.lblGuncelTutar.Size = new System.Drawing.Size(130, 20);
            this.lblGuncelTutar.TabIndex = 14;
            this.lblGuncelTutar.Text = "____________ ₺";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 649);
            this.Controls.Add(this.lblGuncelTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisOnay);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.grpMalzemeler);
            this.Controls.Add(this.rbKalinKenar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rbInceKenar);
            this.Controls.Add(this.lstPizzalar);
            this.Controls.Add(this.cbEbatlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "        PİZZACIM V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpMalzemeler.ResumeLayout(false);
            this.grpMalzemeler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEbatlar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.RadioButton rbInceKenar;
        private System.Windows.Forms.RadioButton rbKalinKenar;
        private System.Windows.Forms.GroupBox grpMalzemeler;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSiparisOnay;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGuncelTutar;
    }
}

