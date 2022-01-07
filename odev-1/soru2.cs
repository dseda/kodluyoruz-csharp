using System;
using System.Collections;
namespace odev_1
{
    // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
    // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
    // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri 
    // console'a yazdırın.
    class soru2
    {
        static void Main(string[] args)
        {    
            string input = "";
            int n,m;
            do {
                Console.WriteLine("Pozitif iki sayı giriniz (n,m)");
                input = Console.ReadLine();
                string[] arr = new string[2];
                try {
                    arr = input.Split(',');
                    n = Convert.ToInt16(arr[0]);
                    m = Convert.ToInt16(arr[1]);
                    if(n>0 && m>0) {
                        EkranaYazdir(n, m);
                        break;
                    }
                    else {
                        Console.WriteLine("Sayı pozitif değil! Pozitif iki sayı giriniz (n,m)");
                    }
                }
                catch(Exception ex){
                    Console.WriteLine("n ya da m sayı değil!", ex.Message);
                }
            } while(input != "");
        }
    
    
        static void EkranaYazdir(int x, int bolen) {
            string  input = "";
            Console.WriteLine(x + " tane pozitif sayı giriniz" );
            int[] pozitifSayilar = new int[x];
            int num = 0;
            int sayi;
            do {
                input = Console.ReadLine();
                try {
                    sayi = Convert.ToInt16(input);
                    if(sayi<=0) {
                        Console.WriteLine("Sayı pozitif değil! Pozitif bir sayı giriniz");
                    }
                    else {
                        pozitifSayilar[num] = sayi;
                        if(x-num-1!=0) {
                            Console.WriteLine(x-num-1 + " adet daha pozitif sayı giriniz");
                        }
                        num++;
                    }
                }
                catch(Exception ex){
                    Console.WriteLine("Sayı değil! Pozitif bir sayı giriniz", ex.Message);
                }
                        
            } while (num<x);

            Console.WriteLine("Girilen sayılardan " + bolen + " ile tam bölünenler");
            int counter = 0;
            foreach (var bolunen in pozitifSayilar)
            {
                if(bolunen%bolen==0) {
                    counter++;
                    Console.WriteLine(bolunen);
                }
            }
            if(counter==0){
                Console.WriteLine("Bölünen sayı bulunamadı.");
            }

        }
    }
}
