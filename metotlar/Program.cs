using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int a =2;
            int b=3;
            // Console.WriteLine(a+b);
            int result = Topla(a,b);
            // Console.WriteLine(result);

            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(result));

            ornek.EkranaYazdir(Convert.ToString(a));
            ornek.EkranaYazdir(Convert.ToString(b));
            
            int result2 = ornek.ArttirVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(result2));
            result2 = ornek.ArttirVeTopla(ref a, ref b);
            // ornek.EkranaYazdir(Convert.ToString(a+b));
            ornek.EkranaYazdir(Convert.ToString(a));
            ornek.EkranaYazdir(Convert.ToString(b));


        }

        static int Topla(int x, int y) {
            return (x+y);
        }
    }

    class Metotlar {
        public void EkranaYazdir(string veri) {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int x, ref int y) {
            x++;
            y++;
            return x+y;
        }
    }
}
