using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23, 12, 4, 5,6, 8, 9};
            Console.WriteLine("***Sirasiz liste***");

            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***Sirali liste***");
            Array.Sort(sayiDizisi);

            foreach (var item2 in sayiDizisi)
            {
                Console.WriteLine(item2);
            }
            Console.WriteLine("***Array Clear***");
            Array.Clear(sayiDizisi,2,2);

            foreach (var item3 in sayiDizisi)
            {
                Console.WriteLine(item3);
            }
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);

            foreach (var item4 in sayiDizisi)
            {
                Console.WriteLine(item4);
            }
            Console.WriteLine("***Array indexOf***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=255;
            foreach (var item5 in sayiDizisi)
            {
                Console.WriteLine(item5);
            }
        }
    }
}
