using System;
using System.Collections;
namespace odev_1
{
    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
    //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
    //Kullanıcının girmiş olduğu sayılardan çift olanlari console'a yazdırın.
    class soru1
    {
        static void Main(string[] args)
        {    
            string input = "";
            int n;
            do {
                Console.WriteLine("Pozitif bir sayı giriniz");
                input = Console.ReadLine();
                try {
                    n = Convert.ToInt16(input);
                    if(n<=0) {
                        Console.WriteLine("Sayı pozitif değil!");
                    }
                    else {
                        Console.WriteLine(n + " tane pozitif sayı giriniz" );
                        int[] pozitifSayilar = new int[n];

                        int num = 0;
                        do {
                            input = Console.ReadLine();
                            try {
                                if(Convert.ToInt16(input)<=0) {
                                    Console.WriteLine("Sayı pozitif değil! Pozitif bir sayı giriniz");
                                }
                                else {
                                    
                                    pozitifSayilar[num] = Convert.ToInt16(input);
                                    if(n-num-1!=0) {
                                        Console.WriteLine(n-num-1 + " adet daha pozitif sayı giriniz");
                                    }
                                    num++;
                                }
                            }
                            catch(Exception ex){
                                Console.WriteLine("Sayı değil!", ex.Message);
                            }
                        
                      
                        } while (num<n);

                        Console.WriteLine("Girilen sayılardan çift olanlar: ");
                        foreach (var item in pozitifSayilar)
                        {
                            if(item%2==0) {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                        

                    }
                    
                }
                catch(Exception ex){
                    Console.WriteLine("Sayı değil!", ex.Message);
                }
            } while(input != "");
        }
    }
}
