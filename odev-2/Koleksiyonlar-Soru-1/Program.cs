using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Koleksiyonlar_Soru_1
{
    /* 
    İstenenler: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan 
    olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.) 
    Negatif ve numeric olmayan girişleri engelleyin.
    Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
    Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet tane pozitif sayı giriniz" );
            int n = 20;
            int[] positiveNumbers = new int[n];
            string input = "";
            int num = 0;
            Console.WriteLine("1. sayıyı giriniz: "); 
            do {
                input = Console.ReadLine();
                try {
                    if(Convert.ToInt16(input)<=0) {
                        Console.WriteLine("Sayı pozitif değil! Pozitif bir sayı giriniz");
                    }
                    else {
                        positiveNumbers[num] = Convert.ToInt16(input);
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

            findPrimes(positiveNumbers);

        }


        static void findPrimes (int[] arr) {
            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();
            
            foreach (var number in arr)
            {   bool isPrime = true;
                for(int i=2; i<=number; i++){
                    if(number % i == 0 && number != i  ) {
                        isPrime = false;
                    }
                }    
                if(isPrime) {
                    primeNumbers.Add(number);
                    
                }
                else{
                    nonPrimeNumbers.Add(number);
                }
               
            }
            primeNumbers.Sort();
            nonPrimeNumbers.Sort();
            Console.Write("\nAsal sayılar (" + primeNumbers.Count.ToString() + " adet): ");
            for(int i=primeNumbers.Count-1; i>=0; i--) 
            {
                Console.Write(primeNumbers[i] + " ");
            }
            Console.WriteLine("\nAsal sayıların ortalaması: " + calculateAverage(primeNumbers));
            Console.Write("\nAsal olmayan sayılar (" + nonPrimeNumbers.Count.ToString() + " adet): ");
            for(int j=nonPrimeNumbers.Count-1; j>=0; j--) 
            {
                Console.Write(nonPrimeNumbers[j] + " ");
            }
            Console.WriteLine("\nAsal olmayan sayıların ortalaması: " + calculateAverage(nonPrimeNumbers));
            
        }

        static double calculateAverage(ArrayList arr) {
            double total = 0.0;
            if(arr.Count!=0) {
                foreach (var item in arr)
                {   
                total+=Convert.ToInt16(item);
                }
                return total/arr.Count;
            }
            else {
                return total;
            }
           
        }
    }
}
