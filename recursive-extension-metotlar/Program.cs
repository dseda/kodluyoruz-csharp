using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result*=3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar

            string ifade = "Seda Demir";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc){
                Console.WriteLine(ifade.RemoveSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,4,5,7,8,3};
            dizi.SortArray();
            dizi.EkranaYazdir();
            Console.WriteLine(dizi[2].IsEvenNumber());
            Console.WriteLine(ifade.GetFirstChar());

        }
    }

    public class Islemler
    {
        public int Expo (int num, int expo ) {
            if(expo<2)
                return num;
            return Expo(num, expo-1) *  num;

        }
    }

    public static class Extensions {
        public static bool CheckSpaces(this string param) {
            return param.Contains(" ");
        } 

        public static string RemoveSpaces(this string param) {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        } 

        public static string MakeUpperCase(this string param) {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param) {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param) {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param) {
            foreach(int item in param){
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param) {
            return param % 2 ==0;
        }

        public static string GetFirstChar(this string param){
            return param.Substring(0,1);
        }
    }
}
