using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazar);   
            Console.WriteLine((int)Gunler.Cumartesi); 
            int sicaklik =32;
            if(sicaklik<= (int)HavaDurumu.Normal) {
                Console.WriteLine("Hava normal");
            }
            else if(sicaklik>= (int)HavaDurumu.CokSicak) {
                Console.WriteLine("Hava Cok Sicak");
            }
            else if(sicaklik>= (int)HavaDurumu.Sicak) {
                Console.WriteLine("Hava sicak");
            }
            
        }
    }

    enum Gunler {
        Pazartesi = 1, 
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu {
        Soguk =5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 35
    }
}
