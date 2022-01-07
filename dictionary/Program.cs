using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "ayse yilmaz");
            kullanicilar.Add(12, "ahmet yilmaz");
            kullanicilar.Add(18, "deniz arda");
            kullanicilar.Add(20, "ozcan cosar");

            Console.WriteLine("*********elemanlara erisim******");

            Console.WriteLine(kullanicilar[10]);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }
              Console.WriteLine(kullanicilar.Count);
              Console.WriteLine(kullanicilar.ContainsKey(20));
              Console.WriteLine(kullanicilar.ContainsValue("ayse yilmaz"));
            
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kullanicilar.Keys);
            Console.WriteLine(kullanicilar.Values);

            string s = "seda 1234";
            s.Split(' ');
            Console.WriteLine(s[0]);
            var x = Console.ReadLine();
            Console.WriteLine(x);
        }
    }
}
