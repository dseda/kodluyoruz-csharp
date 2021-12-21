using System;
using System.Collections;
namespace odev_1
{
    
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
// Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
// Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

    class soru3
    {
        static void Main(string[] args)
        {    
            string input = "";
            int n;
            do {
                Console.WriteLine("Pozitif bir sayı giriniz (n)");
                input = Console.ReadLine();
                try {
                    n = Convert.ToInt16(input);
                    if (n>0) {
                        KelimeleriYazdir(n);
                        break;
                    }
                    else {
                        Console.WriteLine("Sayı pozitif değil!");
                    }
                }
                catch(Exception ex){
                    Console.WriteLine("Sayı değil!", ex.Message);
                }
            } while(input != "");
        }
    
    
        static void KelimeleriYazdir(int n) {
            string  input = "";
            Console.WriteLine(n + " tane kelime giriniz" );
            string[] kelimeler = new string[n];
            int num = n-1;
            do {
                input = Console.ReadLine();
                try {
                    kelimeler[num] = input;
                    num--;
                }
                catch(Exception ex){
                    Console.WriteLine("Hata oluştu", ex.Message,ex);
                }
                        
            } while (num>=0);

            Console.WriteLine("Sondan başa doğru girilen kelime(ler): ");
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
