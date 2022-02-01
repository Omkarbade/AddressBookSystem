﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        //properties of AddressBook
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }


        public void Contact()  //Method to contact 
        {
            Console.WriteLine("FirstName: " + this.FirstName + " LastName: " + this.LastName
                              + " Address: " + this.Address + " City: " + this.City + " State: "
                              + this.State + " Zip: " + this.Zip + " PhoneNumber: "
                              + this.PhoneNumber + " Email: " + this.Email);
        }
    }
}
