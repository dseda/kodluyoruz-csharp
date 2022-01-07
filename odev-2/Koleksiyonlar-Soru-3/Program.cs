using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3
{
    /*
    Klavyeden girilen cümle içerisindeki sesli harfleri 
    bir dizi içerisinde saklayan ve dizinin elemanlarını 
    sıralayan programı yazınız.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiıoöuü";
            ArrayList vowelsInSentence = new ArrayList();

            Console.WriteLine("Bir cümle giriniz");
            string sentence = Console.ReadLine();
            
            foreach(var letter in sentence.ToLower()) {
                if(vowels.Contains(letter) && !vowelsInSentence.Contains(letter)) {
                    vowelsInSentence.Add(letter);
                }
            }
            Console.Write("Cümledeki sesli harfler: ");

            foreach (var item in vowelsInSentence)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            
        }
    }
}
