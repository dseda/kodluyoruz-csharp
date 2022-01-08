using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {   
            int option=0;
            List<Contact> contactsList = new List<Contact>();
            do {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
            Console.WriteLine("******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(6) Çıkış Yapmak");

            option = Convert.ToInt16(Console.ReadLine());
            
            switch(option) {
                case 1: 
                    Console.WriteLine("Yeni Numara Kaydetmek");
                    Console.WriteLine("Lütfen isim giriniz             :");
                    string first_name = Console.ReadLine();
                    Console.WriteLine("Lütfen soyisim giriniz          :");
                    string last_name = Console.ReadLine();
                    Console.WriteLine("Lütfen telefon numarası giriniz :");
                    string phone = Console.ReadLine();
                    Contact contact = new Contact(first_name, last_name, phone);
                    contactsList.Add(contact);
                    break;
                case 2: 
                    Console.WriteLine("Varolan Numarayı Silmek");
                    break;
                case 4: 
                    Console.WriteLine("Rehberi Listelemek");
                    foreach (var item in contactsList) 
                    {
                        Console.WriteLine(item.getFirstName() + " " + item.getLastName() + " " + item.getPhone());
                    }
                    break;
            }
        } while (Convert.ToInt16(option) != 6 );
       

        }
    }
}
