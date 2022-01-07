using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ogrenci o1 = new Ogrenci("Seda", "Demir", "555", 4);
            o1.OgrenciBilgileriniGetir();
            Ogrenci o2 = new Ogrenci("Seda", "Deniz", "544", 3);
            o2.OgrenciBilgileriniGetir();
            o2.SinifDusur();
            o2.SinifDusur();
            o2.SinifDusur();
            o2.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci {

        private string isim;
        private string soyisim;
        private string ogrenciNo;

        private int sinif;

        public string Isim { 
            get => isim; 
            set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set{
                if(value<1)
                {
                    Console.WriteLine("Sinif en az 1 olabilir");
                    sinif=1;
                }
                else
                {
                    sinif = value;
                }

            }   
            }

        public Ogrenci(string isim, string soyisim, string ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci() {}

        public void OgrenciBilgileriniGetir() {

            Console.WriteLine("*******Ogrenci Bilgileri*********");
            Console.WriteLine("Ogrenci Adi: " + this.Isim);
            Console.WriteLine("Ogrenci Soyadi: " + this.Soyisim);
            Console.WriteLine("Ogrenci No: " + this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi: " + this.Sinif);
            
        }

        public void SinifAtlat() {
            this.Sinif++;
        }
        public void SinifDusur() {
            this.Sinif--;
        }


    }
}
