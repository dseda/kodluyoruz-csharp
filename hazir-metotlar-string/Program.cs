using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string degisken = "Dersimiz C Sharp";
            string degisken2 = "C Sharp";

            Console.WriteLine(degisken.Length);

            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            Console.WriteLine(String.Concat(degisken, " Merhaba"));

            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken,degisken2, true));
            Console.WriteLine(String.Compare(degisken,degisken2, false));
            
            
            Console.WriteLine(degisken.Contains(degisken2));

            Console.WriteLine(degisken.EndsWith("p"));
            Console.WriteLine(degisken.StartsWith("C"));

            Console.WriteLine(degisken.IndexOf("C Sharp"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            Console.WriteLine(degisken.Insert(0, "Merhaba"));
            
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));

            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(0,1));

            Console.WriteLine(degisken.Replace("C Sharp", "C#"));

            Console.WriteLine(degisken.Split(" ")[1]);

            Console.WriteLine(degisken.Substring(4,6));











        }
    }
}
