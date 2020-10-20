using System;
namespace addBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AddressBookBuilder addressBookBuilder = new AddressBookBuilder();
            while (true)
            {
                Console.WriteLine("1. Add Contact\n 2. Display Contacts\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email;
                        Console.WriteLine("Enter First Name : ");
                        FirstName = Console.ReadLine();
                        Console.WriteLine("Enter Last Name : ");
                        LastName = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        Address = Console.ReadLine();
                        Console.WriteLine("Enter City : ");
                        City = Console.ReadLine();
                        Console.WriteLine("Enter State : ");
                        State = Console.ReadLine();
                        Console.WriteLine("Enter Zip code : ");
                        Zip = Console.ReadLine();
                        Console.WriteLine("Enter Phone Number : ");
                        PhoneNumber = Console.ReadLine();
                        Console.WriteLine("Enter Email : ");
                        Email = Console.ReadLine();
                        addressBookBuilder.addContact(FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email);
                        break;
                    case 2:
                        addressBookBuilder.displayContacts();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Choice");
                        break;
                }

            }
        }
    }
}