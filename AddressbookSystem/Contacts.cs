using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contacts
    {  
        // variables
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        // constructor which get user detail.
        public Contacts(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        // Method to Display the contact detail.
        public void Display()
        {
            Console.WriteLine("First Name:{0}", this.FirstName);
            Console.WriteLine("Last Name:{0}", this.LastName);
            Console.WriteLine("Address:{0}", this.Address);
            Console.WriteLine("City: {0}", this.City);
            Console.WriteLine("State:{0}", this.State);
            Console.WriteLine("Zipcode:{0}", this.ZipCode);
            Console.WriteLine("phone number:{0}", this.PhoneNumber);
            Console.WriteLine("Email:{0}", this.Email);
        }
    }
}
