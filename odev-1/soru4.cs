using System;
using System.Collections;
namespace odev_1
{
    
// Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
// Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


    class soru4
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("Bir cümle giriniz");

            string cumle = Console.ReadLine();
            string alfabe = "abcçdefgğhiıjklmnoöprsştuüvyz";

            int kelimeSayisi = cumle.Split(' ').Length;
            int harfSayisi = 0;
            
            foreach(var letter in cumle.ToLower()) {
                if(alfabe.Contains(letter))
                    harfSayisi++;
            }
            
            Console.WriteLine("Cümledeki harf sayısı: " + harfSayisi + ", Kelime sayısı: " + kelimeSayisi);
        }
    }
}
