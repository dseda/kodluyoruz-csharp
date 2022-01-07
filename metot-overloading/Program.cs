using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if(sonuc) {
                Console.WriteLine("Basarili");
                Console.WriteLine(outSayi);
             
            }
            else {
                Console.WriteLine("Basarisiz!");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            int sayi2 = 999;
            instance.EkranaYazdir(Convert.ToString(sayi2));
            instance.EkranaYazdir(sayi2);
            instance.EkranaYazdir("Seda", "Demir");
            //Metot Imzasi
            // MetotAdi + Parametre sayisi + Parametre
        }
    }

    class Metotlar {
        public void Topla(int a, int b, out int toplam) {
            toplam = a+b;
        }
        public void EkranaYazdir(string veri) {
                Console.WriteLine(veri);
            }

        public void EkranaYazdir(int veri) {
                Console.WriteLine(veri);
            }

        public void EkranaYazdir(string veri1, string veri2) {
                Console.WriteLine(veri1+ " " + veri2);
            }
    }
}
