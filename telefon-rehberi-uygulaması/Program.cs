using System;
using System.Collections.Generic;
namespace telefon_rehberi_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {   
            int operation=0;
            List<Contact> contactsList = new List<Contact>();
            ContactsOperations ops = new ContactsOperations();

            do {
                ops.ViewOptions();
                operation = Convert.ToInt16(Console.ReadLine());
                switch(operation) {
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
        } while (Convert.ToInt16(operation) != 6 );
       

        }
    }
}
