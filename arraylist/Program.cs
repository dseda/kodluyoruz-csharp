using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("ayse");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            Console.WriteLine(liste[1]);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********");
            //AddRange
            string[] renkler = {"kirmizi", "sari", "yesil"};
            List<int> sayilar = new List<int>{1,3,4,5,7};
            liste.AddRange(renkler);

            foreach (var item2 in liste)
            {
                Console.WriteLine(item2);
            }
            //BinarySearch
            Console.WriteLine(liste.BinarySearch(9));

            liste.Reverse();
            // Console.WriteLine(liste.BinarySearch(9));

            foreach (var item3 in liste)
            {
                Console.WriteLine(item3);
            }

            liste.Clear();





        }
    }
}
