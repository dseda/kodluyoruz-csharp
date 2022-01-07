using System;

namespace kurucu_constructor_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan 1");
            Calisan c1 = new Calisan();
            c1.Ad = "Ayse";
            c1.Soyad = "Kara";
            c1.No = 321;
            c1.Departman = "IK";
            c1.CalisanBilgileri();

            Console.WriteLine("Calisan 2");
            Calisan c2 = new Calisan("Arda", "Tunca", 432, "IK");
            c2.CalisanBilgileri();

            Console.WriteLine("Calisan 3");
            Calisan c3 = new Calisan("Seda", "Demir");
            c3.CalisanBilgileri();
        }

        

    }

    class Calisan {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;

        }

        public Calisan() {}

         public Calisan(string ad, string soyad) {
             this.Ad =ad;
             this.Soyad =soyad;
         }
        public void CalisanBilgileri ()
        {
            Console.WriteLine("Calisanin adi: " +Ad);
            Console.WriteLine("Calisanin soyadi: " + Soyad);
            Console.WriteLine("Calisanin Numarasi: " + No);
            Console.WriteLine("Calisanin Departmani: " + Departman);
        }




    }
}
