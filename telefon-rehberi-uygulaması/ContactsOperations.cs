using System;
using System.Collections.Generic;

namespace telefon_rehberi_uygulaması
{
    class ContactsOperations {
        
        public void ViewOptions() {
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
        }
        public void AddContact(List<Contact> contactList) {
            Console.WriteLine("Yeni Numara Kaydetmek");
            Console.WriteLine("Lütfen isim giriniz             :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            string last_name = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string phone = Console.ReadLine();
            Contact newContact = new Contact(first_name, last_name, phone);
            contactList.Add(newContact);
            Console.WriteLine("Kişi rehbere eklendi");
        }

        public void DeleteContact(List<Contact> contactList) {
            Console.WriteLine("Silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            Console.WriteLine("Lütfen isim giriniz    :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            string last_name = Console.ReadLine();
            var contact = contactList.Find( 
                x => x.getFirstName() == first_name ||
                x.getLastName() == last_name  );
            if(contact != null) {
                Console.WriteLine(contact.getFirstName() + " " + contact.getLastName() 
                + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string confirmation = Console.ReadLine();
                if(confirmation == "y" || confirmation == "yes" ){
                    contactList.Remove(contact);
                    Console.WriteLine("Kişi rehberden silindi");
                }
            }
            else{
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int option = Convert.ToInt16(Console.ReadLine());
                if (option == 2) {
                    DeleteContact(contactList);
                } 
            }
        }
        public void ViewContacts(List<Contact> contactList) {
            Console.WriteLine("Rehberi Listelemek");
            Console.WriteLine("İsim".PadRight(15, ' ') + "Soyisim".PadRight(15, ' ') + "Phone".PadRight(15, ' ') );
            Console.WriteLine();
            foreach (var item in contactList) 
                {
                    Console.WriteLine(
                        item.getFirstName().PadRight(15, ' ') 
                        + item.getLastName().PadRight(15, ' ') 
                        + item.getPhone().PadRight(15, ' '));
                }
        }

        // public void Update(Contact contact, string first_name, string last_name, string phone) {
        //     Console.WriteLine("Contact updated");
        // }
    
    }
}