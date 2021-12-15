using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        { 

            try
            {
                // Console.WriteLine("Bir sayi giriniz");
                // int sayi = Convert.ToInt32(Console.ReadLine());
                // Console.WriteLine("Girmiş olduğunuz sayı " + sayi);
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-200000");
            }
            catch(ArgumentNullException ex) {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            finally {
                Console.WriteLine("Islem basariyla tamamlandi")
            }
   
            
       
       
        }
    }
}
