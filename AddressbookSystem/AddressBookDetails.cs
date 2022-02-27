﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookDetails
    {
        //Collection Class
        private List<Contacts> contactList;
        public AddressBookDetails()
        {
            this.contactList = new List<Contacts>();
        }

        //Method to Add Contact in address book
        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, int zipCode, long phoneNumber, string email)
        {
            // finding the data that already has the same first name
            Contacts contact = this.contactList.Find(x => x.FirstName.Equals(firstName));
            if (contact == null) // using if condition to add contact if not present 
            {
                Contacts contactDetails = new Contacts(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
                this.contactList.Add(contactDetails);
            }
            else
            {
                Console.WriteLine("Person {0} is already exist in the address book", firstName); //printing message if person name is already in address book

            }
        }
        //Method to Display Contact in address book
        public void DisplayContact()
        {

            if (this.contactList.Count != 0)  //checking ContactList is empty or not
            {
                foreach (Contacts data in this.contactList)
                {
                    data.Display();
                }
            }
            else
                Console.WriteLine("No Contacts in AddressBook");
        }
        public void EditContact(string ename) //Method to Edit Contact 
        {
            // checks for every object whether the name is equal to the given name
            foreach (Contacts data in this.contactList)
            {
                if (data.FirstName.Equals(ename))
                {
                    Console.WriteLine("Enter your choice:");
                    Console.WriteLine("1. Last Name");
                    Console.WriteLine("2. Address");
                    Console.WriteLine("3. City");
                    Console.WriteLine("4. State");
                    Console.WriteLine("5. Zip");
                    Console.WriteLine("6. Phone Number");
                    Console.WriteLine("7. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            data.LastName = Console.ReadLine();
                            Console.WriteLine("Last name updated successfully");
                            break;
                        case 2:
                            data.Address = Console.ReadLine();
                            Console.WriteLine("Address updated successfully");
                            break;
                        case 3:
                            data.City = Console.ReadLine();
                            Console.WriteLine("City updated successfully");
                            break;
                        case 4:
                            data.State = Console.ReadLine();
                            Console.WriteLine("State updated successfully");
                            break;
                        case 5:
                            data.ZipCode = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Zipcode updated successfully");
                            break;
                        case 6:
                            data.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Phonenumber updated successfully");
                            break;
                        case 7:
                            data.Email = Console.ReadLine();
                            Console.WriteLine("Email updated successfully");
                            break;
                        default:
                            Console.WriteLine("Please check your choice");
                            break;
                    }
                }
                else
                    Console.WriteLine("Error,No Contact With this Name");
            }
        }
        //Method to Delete a contact deatils of person
        public void DeleteContact(string dName)
        {
            foreach (Contacts c in this.contactList)
            {
                if (c.FirstName.Equals(dName))
                {
                    this.contactList.Remove(c);
                    Console.WriteLine("Contact is successfully Deleted");
                    break;
                }
            }
        }
        public static void SearchPersonWithCityorStateName(Dictionary<string, AddressBookDetails> addressDictionary)
        {
            List<Contacts> list = null;
            Console.WriteLine("Enter City or State name to search specific person");
            string name = Console.ReadLine();
            foreach (var data in addressDictionary)
            {
                AddressBookDetails address = data.Value;
                list = address.contactList.FindAll(a => a.City.Equals(name) || a.State.Equals(name));
                if (list.Count > 0)
                {
                    DisplayList(list);
                }
            }
            if (list == null)
            {
                Console.WriteLine("No person is present in the address book with same city or state name");
            }
        }
        //Method to display the data in the list 
        public static void DisplayList(List<Contacts> list)
        {
            foreach (var data in list)
            {
                data.Display();
            }
        }
    }
}
