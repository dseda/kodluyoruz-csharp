using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{   
    /*
    İstenenler: Klavyeden girilen 20 adet sayının en büyük 3 tanesi 
    ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde 
    ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını 
    console'a yazdıran programı yazınız. 
    (Array sınıfını kullanarak yazınız.)
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet benzersiz pozitif sayı giriniz" );
            int n = 20;
            ArrayList positiveNumbers = new ArrayList(20);
            string input = "";
            int num = 0;
            Console.WriteLine("1. sayıyı giriniz: "); 
            do {
                input = Console.ReadLine();
                try {
                    if(Convert.ToInt16(input)<=0) {
                        Console.WriteLine("Sayı pozitif değil! Pozitif bir sayı giriniz");
                    }
                    else if(positiveNumbers.Contains(Convert.ToInt16(input))) {
                        Console.WriteLine("Sayı zaten mevcut");
                    }
                    else {
                        positiveNumbers.Add(Convert.ToInt16(input));
                        if(n-num-1 != 0 ) {
                            Console.WriteLine(num + 2 + ". sayıyı giriniz: ");
                        }
                        num++;
                    }
                }
                catch(Exception ex){
                    Console.WriteLine("Sayı değil!", ex.Message);
                }
            } while (num<n);

            positiveNumbers.Sort();

            int[] maxNumbers = new int[3];
            int[] minNumbers = new int[3];

            maxNumbers[0] = Convert.ToInt16(positiveNumbers[17]);
            maxNumbers[1] = Convert.ToInt16(positiveNumbers[18]);
            maxNumbers[2] = Convert.ToInt16(positiveNumbers[19]);

            minNumbers[0] = Convert.ToInt16(positiveNumbers[0]);
            minNumbers[1] = Convert.ToInt16(positiveNumbers[1]);
            minNumbers[2] = Convert.ToInt16(positiveNumbers[2]);

            Console.WriteLine("Girilen sayılardan en büyük 3 tanesi: " + maxNumbers[0] + " " + maxNumbers[1] + " " +maxNumbers[2]);
            Console.WriteLine("En büyük sayıların toplamı " + calculateSum(maxNumbers));
            Console.WriteLine("En büyük sayıların ortalaması " + calculateAverage(maxNumbers));
            
            Console.WriteLine();
            Console.WriteLine("Girilen sayılardan en küçük 3 tanesi: " + minNumbers[0] + " " + minNumbers[1] + " " +minNumbers[2]);
            Console.WriteLine("En küçük sayıların toplamı " + calculateSum(minNumbers));
            Console.WriteLine("En küçük sayıların ortalaması " + calculateAverage(minNumbers));

        }
        static double calculateAverage(int[] arr) {
            double total = 0.0;
            if(arr.Length !=0) {
                foreach (var item in arr)
                {   
                total+=Convert.ToInt16(item);
                }
                return total/arr.Length;
            }
            else {
                return total;
            }
        }
        static double calculateSum(int[] arr) {
            int total = 0;
            if(arr.Length !=0) {
                foreach (var item in arr)
                {   
                total+=item;
                }
                return total;
            }
            else {
                return total;
            }
        }
    }
}
