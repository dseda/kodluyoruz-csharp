using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan sayisi: " + Calisan.CalisanSayisi);
            
            Calisan c1 = new Calisan("Seda", "Demir", "Yazılım");
            
            Console.WriteLine("Calisan sayisi: " + Calisan.CalisanSayisi);
            Calisan c2 = new Calisan("Sena", "Demir", "IK");
            Console.WriteLine("Calisan sayisi: " + Calisan.CalisanSayisi);

            Console.WriteLine("Toplama isleminin sonucu: " + Islemler.Topla(400, 60));
            Console.WriteLine("Cikarma isleminin sonucu: " + Islemler.Cikar(400, 60));

        }


    }

    class Calisan {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;  }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan (string isim, string soyisim, string departman) {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }




    }

    static class Islemler {

        public static long Topla (int sayi1, int sayi2) {

            return sayi1 + sayi2;
        }

        public static long Cikar (int sayi1, int sayi2) {

            return sayi1 - sayi2;
        }

    }

}
