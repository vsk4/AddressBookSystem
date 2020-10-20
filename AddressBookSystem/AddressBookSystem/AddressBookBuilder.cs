using System;
using System.Collections.Generic;
using System.Text;
namespace addBook
{
    class AddressBookBuilder : IContacts
    {
        public Dictionary<string, Contacts> dictionary;
        public AddressBookBuilder()
        {
            this.dictionary = new Dictionary<string, Contacts>();
        }
        public void addContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNo, string email)
        {
            Contacts contact = new Contacts(firstName, lastName, address, city, state, zip, phoneNo, email);
            dictionary.Add(firstName, contact);
        }
        public void displayContacts()
        {
            foreach (KeyValuePair<string, Contacts> dict in dictionary)
            {
                Console.WriteLine("First Name : " + dict.Value.firstName);
                Console.WriteLine("Last Name : " + dict.Value.lastName);
                Console.WriteLine("Address : " + dict.Value.address);
                Console.WriteLine("City : " + dict.Value.city);
                Console.WriteLine("State : " + dict.Value.state);
                Console.WriteLine("Zip : " + dict.Value.zip);
                Console.WriteLine("Phone Number : " + dict.Value.phoneNo);
                Console.WriteLine("Email : " + dict.Value.email);
            }
        }
    }
}