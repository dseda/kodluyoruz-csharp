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
            ContactsOperations ops = new ContactsOperations();
            do {
                Console.WriteLine();
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(6) Çıkış Yapmak");
                Console.WriteLine();

                option = Convert.ToInt16(Console.ReadLine());
                
                switch(option) {
                    case 1: 
                        ops.AddContact(contactsList);
                        break;
                    case 2: 
                        ops.DeleteContact(contactsList);
                        break;
                    
                    case 4: 
                        ops.ViewContacts(contactsList);
                        break;
                }
        } while (Convert.ToInt16(option) != 6 );
       

        }
    }
}
