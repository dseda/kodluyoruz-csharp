using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi", "kopek", "kus", "maymun"};
            int[] dizi;
            dizi = new int[5];
            renkler[0] = "Mavi";
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            Console.WriteLine("Dizinin eleman sayisini giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] dizim = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lutfen {0}. sayiyi giriniz", i+1);
                dizim[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var s in dizim)
            {
                toplam+=s;
            }
            Console.WriteLine("Ortalama :" + toplam/diziUzunlugu);
        }
    }
}
