using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            // if (time>=6 && time <=11)
            // Console.WriteLine("Gunaydin");
            // else if (time <=18)
            // Console.WriteLine("Iyi gunler");
            // else 
            // Console.WriteLine("Iyi Geceler");

            string sonuc = "";

            sonuc = time>=6 && time <=11 ? "Gunaydinn" : time <= 18 ? "Iyi gunlerr" : "Iyi Gecelerr";
             Console.WriteLine(sonuc);
        }

    }
}
