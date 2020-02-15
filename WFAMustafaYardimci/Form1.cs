using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAMustafaYardimci.Models;

namespace WFAMustafaYardimci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region PizzaMenüsü
        Pizza[] pizzamenu =

         {
             new Pizza () {Adi = "Klasik",Fiyati=14},
             new Pizza () {Adi = "Karışık",Fiyati=17},
             new Pizza () {Adi = "Extravaganza",Fiyati=21},
             new Pizza () {Adi = "Italiano",Fiyati=20},
             new Pizza () {Adi = "Turkish",Fiyati=23},
             new Pizza () {Adi = "Tuna",Fiyati=18},
             new Pizza () {Adi = "Seafeed",Fiyati=19},
             new Pizza () {Adi = "Kastamonu",Fiyati=20},
             new Pizza () {Adi = "Calypso",Fiyati=24},
             new Pizza () {Adi = "Akdeniz",Fiyati=21},
             new Pizza () {Adi = "Karadeniz",Fiyati=21}
        };  
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Pizza item in pizzamenu)
            {
                lstPizzalar.Items.Add(item);
            }
            
             string[] boyut = { "Küçük", "Orta", "Büyük", "Maxi" };
             cbEbatlar.Items.AddRange(boyut);
             
             
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            
                Siparisler siparis = new Siparisler();
                siparis.SeciliPizza = (Pizza)lstPizzalar.SelectedItem;


            #region Kenar Seçimi
            if (rbInceKenar.Checked) siparis.SeciliKenar = Kenar.Ince;
            else if (rbKalinKenar.Checked) siparis.SeciliKenar = Kenar.Kalin;
            else
            {
                MessageBox.Show("Lütfen İnce veya Kalın Kenar Seçin.");
                return;
            }
            #endregion
            #region Boyut Seçimi

            if (cbEbatlar.Text == "Küçük") siparis.SeciliBoyut = Boyut.Kucuk;
            else if (cbEbatlar.Text == "Orta") siparis.SeciliBoyut = Boyut.Orta;
            else if (cbEbatlar.Text == "Büyük") siparis.SeciliBoyut = Boyut.Buyuk;
            else if (cbEbatlar.Text == "Maxi") siparis.SeciliBoyut = Boyut.Maxi;
            else
            {
                MessageBox.Show("Lütfen Boyut Seçimi Yapınız.");
                return;
            } 
            #endregion

            foreach (CheckBox item in grpMalzemeler.Controls)
            {
                if (item.Checked)
                {
                    ExtraMalzeme ex = new ExtraMalzeme();
                    ex.Adi = item.Text;
                    ex.Fiyati = Convert.ToDecimal(item.Tag);
                    siparis.ExtraMalzemeler.Add(ex);
                }
            }
            
            lblGuncelTutar.Text = txtTutar.Text;
            txtAdet.Text = null;
            txtTutar.Text = null;
        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            decimal tutar = 0;
            int adet = 0;
            foreach (Siparisler item in lstSiparisler.Items)
            {
                adet++;
                tutar += item.ToplamTutar;
            }
            // Toplam 3 adet siparişiniz 40 TL tutarındadır.
            
            MessageBox.Show($"Toplam {adet} adet siparişiniz {tutar} TL tutarındadır.");
            lstSiparisler.Items.Clear();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Siparisler siparis = new Siparisler();
                siparis.SeciliPizza = (Pizza)lstPizzalar.SelectedItem;
                siparis.Adet = Convert.ToInt32(txtAdet.Text);
                siparis.TutarHesapla();
                lstSiparisler.Items.Add(siparis);
                decimal tutar = 0;
                foreach (Siparisler item in lstSiparisler.Items)
                {
                    tutar += item.ToplamTutar;
                }
                txtTutar.Text = tutar.ToString("C2");
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Adet'e sayı giriniz.");
            }
        }
    }
}
