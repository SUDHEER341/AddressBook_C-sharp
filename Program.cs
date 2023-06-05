namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("Address Book Menu:");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Print Contacts");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Name:");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName:");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter Contact Number:");
                        string ContactNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email ID:");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Enter Your city:");
                        string City = Console.ReadLine();
                        Console.WriteLine("Enter Your state :");
                        string State = Console.ReadLine();
                        Console.WriteLine("Enter Your Zip code:");
                        string ZipCode = Console.ReadLine();


                        Contact contact = new Contact
                        {
                            FirstName = FirstName,
                            LastName = LastName,
                            ContactNumber = ContactNumber,
                            Email = Email,
                            City = City,
                            State = State,
                            ZipCode = ZipCode
                            
                        };

                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact added successfully.");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter the name of the contact to edit:");
                        string editName = Console.ReadLine();

                        Console.WriteLine("Enter FirstName:");
                        string editFirstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName:");
                        string editLastName = Console.ReadLine();
                        Console.WriteLine("Enter ContactNumber:");
                        string editContactNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email:");
                        string editEmail = Console.ReadLine();
                        Console.WriteLine("Enter City:");
                        string editCity = Console.ReadLine();
                        Console.WriteLine("Enter State:");
                        string editState = Console.ReadLine();
                        Console.WriteLine("Enter Zip Code:");
                        string editZipCode = Console.ReadLine();

                        Contact editedContact = new Contact
                        {
                            FirstName = editFirstName,
                            LastName = editLastName,
                            ContactNumber = editContactNumber,
                            Email = editEmail,
                            City = editCity,
                            State = editState,
                            ZipCode = editZipCode
                        };

                        addressBook.EditContact(editName, editedContact);
                        Console.WriteLine();
                        break;

                    // DELETE CONTACT BASED ON INDEX
                    //case 3:
                    //    Console.WriteLine("Enter the index of the contact to delete:");
                    //    int deleteIndex = int.Parse(Console.ReadLine());

                    //    if (deleteIndex >= 1 && deleteIndex <= addressBook.contactCount)
                    //    {
                    //        addressBook.DeleteContact(deleteIndex - 1);
                    //        Console.WriteLine("Contact deleted successfully.");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("Invalid index.");
                    //    }

                    //    Console.WriteLine();
                    //    break;

                        // DELETE CONTACT BASED ON FIRST NAME
                        case 3:
                        Console.WriteLine("enter the first name to delete the contact");
                        string deleteFirstName = Console.ReadLine();
                        addressBook.DeleteContact(deleteFirstName);
                        break;

                    case 4:
                        addressBook.PrintContacts();
                        Console.WriteLine();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}