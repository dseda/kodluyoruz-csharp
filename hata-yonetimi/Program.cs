using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        { 

            try
            {
                Console.WriteLine("Bir sayi giriniz");
            
                int sayi = Convert.ToInt32("6");
                Console.WriteLine("Girmiş olduğunuz sayı " + sayi);
                // int c = int.Parse(null);
                // int b = int.Parse("test");
                int a = int.Parse("-200000");
   
            }
            catch(ArgumentNullException ex) {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            finally {
                Console.WriteLine("Islem basariyla tamamlandi");
            }
   
            
       
       
        }
    }
}
