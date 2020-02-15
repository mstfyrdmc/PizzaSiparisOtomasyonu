using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAMustafaYardimci.Models
{
    public class Siparisler
    {
        public Siparisler()
        {
            ExtraMalzemeler = new List<ExtraMalzeme>();
        }
        public Pizza SeciliPizza { get; set; }
        public Boyut SeciliBoyut { get; set; }
        public Kenar SeciliKenar { get; set; }
        public List<ExtraMalzeme> ExtraMalzemeler { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void TutarHesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliPizza.Fiyati;

            #region Boyuta Göre Fiyatlandırma
            switch (SeciliBoyut)
            {
                case Boyut.Kucuk:
                    break;
                case Boyut.Orta:
                    ToplamTutar *= 1.25m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar *= 1.5m;
                    break;
                case Boyut.Maxi:
                    ToplamTutar *= 2;
                    break;
            }
            #endregion
            #region Ekstra Malzemelerin Fiyatlandırılması
            foreach (ExtraMalzeme item in ExtraMalzemeler)
            {
                ToplamTutar += item.Fiyati;
            } 
            #endregion

            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
           //Pizza Adı Pizza , Boyut Boy ,Kenar Kenar , Adet , -> Toplam Tutar: 25TL

            if(ExtraMalzemeler.Count < 1)
            {
                return $"{SeciliPizza} Pizza , {SeciliBoyut} Boy, {SeciliKenar} Kenar , {Adet} Adet , -> Toplam Tutar: {ToplamTutar.ToString("C2")}" ;
            }
            else
            {
                //Pizza Adı Pizza , Boyut Boy ,Kenar Kenar , Adet ,(...,...,...), -> Toplam Tutar: 25TL
                string extra = null;
                foreach (ExtraMalzeme item in ExtraMalzemeler)
                {
                    extra += item.Adi + ",";
                }
                extra = extra.TrimEnd(',');
                return $"{SeciliPizza} Pizza , {SeciliBoyut} Boy, {SeciliKenar} Kenar , {Adet} Adet ,({extra}), -> Toplam Tutar: {ToplamTutar.ToString("C2")}";
            }
        }

    }
        
        
}
