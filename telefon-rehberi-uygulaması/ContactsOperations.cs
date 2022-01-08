using System;
using System.Collections.Generic;

namespace telefon_rehberi_uygulaması
{
    class ContactsOperations {
        
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
            Console.WriteLine("New contact has been added");
        }

        public void DeleteContact(List<Contact> contactList) {
            Console.WriteLine("Silmek istediğiniz kişinin adını ve soyadını giriniz: ");
            Console.WriteLine("Lütfen isim giriniz    :");
            string first_name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            string last_name = Console.ReadLine();
            var contact = contactList.Find( 
                x => x.getFirstName() == first_name ||
                x.getLastName() == last_name  );
            if(contact != null) {
                Console.WriteLine("Contact has been deleted");
                contactList.Remove(contact);
                Console.WriteLine("Contact has been deleted");
            }
            else{
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.")
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
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