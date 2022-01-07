using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // int sayi = int.Parse(Console.ReadLine());
            // for (int i =0; i<=sayi; i++) {
            //     if (i%2==1) {
            //         Console.WriteLine(i);
            //     }
            // }

            int tekToplam = 0;
            int ciftToplam = 0;
             for (int i =0; i<=1000; i++) {
                 if(i%2==1) {
                     tekToplam+=i;
                 }
                 else 
                    ciftToplam+=i;
             }
            //  Console.WriteLine(tekToplam + ", " + ciftToplam);

             //Break, Continue
            for (int i =0; i<=10; i++) {
                 if(i==4) {
                     break;
                 }
                 Console.WriteLine(i);
             }
             for (int i =11; i<=20; i++) {
                 if(i==14) {
                     continue;
                 }
                 Console.WriteLine(i);
             }

        }
    }
}
