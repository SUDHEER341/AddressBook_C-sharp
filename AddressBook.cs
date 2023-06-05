using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
    class AddressBook
    {
        private const int MaxContacts = 10;
        private Contact[] contacts;
        public int contactCount;

        public AddressBook()
        {
            contacts = new Contact[MaxContacts];
            contactCount = 0;
        }

        public void AddContact(Contact contact)
        {
            if (contactCount < MaxContacts)
            {
                contacts[contactCount] = contact;
                contactCount++;
            }
            else
            {
                Console.WriteLine("Address book is full. Cannot add more contacts.");
            }
        }


        public void EditContact(string contactName, Contact newContact)
        {
            int index = -1;

            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(contactName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                contacts[index] = newContact;
                Console.WriteLine("Contact edited successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        //public void DeleteContact(int index)
        //{
        //    if (index >= 0 && index < contactCount)
        //    {
        //        for (int i = index; i < contactCount - 1; i++)
        //        {
        //            contacts[i] = contacts[i + 1];
        //        }
        //        contactCount--;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid contact index.");
        //    }
        //}
        public void DeleteContact(string contactName)
        {
            int index = -1;

            for (int i = 0; i < contactCount; i++)
            {
                if (contacts[i].FirstName.Equals(contactName, StringComparison.OrdinalIgnoreCase))
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < contactCount - 1; i++)
                {
                    contacts[i] = contacts[i + 1];
                }
                contactCount--;

                Console.WriteLine("Contact deleted successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void PrintContacts()
        {
            Console.WriteLine("Contacts:");

            for (int i = 0; i < contactCount; i++)
            {
                Console.WriteLine($"Contact {i + 1}:");
                Console.WriteLine($"FirstName: {contacts[i].FirstName}");
                Console.WriteLine($"LastName: {contacts[i].LastName}");
                Console.WriteLine($"ContactNumber: {contacts[i].ContactNumber}");
                Console.WriteLine($"Email: {contacts[i].Email}");
                Console.WriteLine($"City: {contacts[i].City}");
                Console.WriteLine($"State: {contacts[i].State}");
                Console.WriteLine($"ZipCode: {contacts[i].ZipCode}");
                
                Console.WriteLine();



            }
        }
    }
}
