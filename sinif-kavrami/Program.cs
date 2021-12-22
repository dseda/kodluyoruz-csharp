using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calisan c1 = new Calisan();
            c1.Ad = "Ayse";
            c1.Soyad = "Kara";
            c1.No = 321;
            c1.Departman = "IK";
            c1.CalisanBilgileri();
        }

        

    }

    class Calisan {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri ()
        {
            Console.WriteLine("Calisanin adi: " +Ad);
            Console.WriteLine("Calisanin soyadi: " + Soyad);
            Console.WriteLine("Calisanin Numarasi: " + No);
            Console.WriteLine("Calisanin Departmani: " + Departman);
        }




    }
}
