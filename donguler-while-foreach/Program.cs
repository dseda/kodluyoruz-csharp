using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int sayi = 10;
            int sayac = 1;
            int toplam = 0;
            while (sayac <=sayi) {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            char character = 'a';
            while (character<='z') {
                Console.Write(character);
                character++;
            } 
            string[] arabalar = {"BMV", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar) {
                Console.WriteLine(araba);
            }
           
        }
    }
}
