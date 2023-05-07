using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Program
    {

        static Dictionary<string, Contact> GetContact()
        {
            return new Dictionary<string, Contact>
            {

            };
        }

        static void Main(string[] args)
        {
            Dictionary<string, Contact> contacts = GetContact();


            bool done = false;
            while (!done)
            {
                Console.WriteLine("Select what do you want to do(Add, ShowAll, ShowContact, SearchContact, Quit ):");
                string Menu = Console.ReadLine().ToLower();
                switch (Menu)
                {
                    case "add":                        
                        ContactRepository.AddNewContact(contacts);
                        break;
                    case "showcontact":
                        ContactRepository.ShowContact(contacts);
                        break;
                    case "showall":
                        ContactRepository.ShowAllContacts(contacts);
                        break;
                    case "searchcontact":
                        ContactRepository.SearchContacts(contacts);
                        break;
                    case "quit":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("There isn't option for this input");
                        break;
                        
                        


                }


                //if (Menu == "add")
                //{
                //    Console.Write("Write your number:");
                //    string TeleNumber = Console.ReadLine();
                //    Console.Write("Write your contact name:");
                //    string ContactName = Console.ReadLine();
                //    contacts.TryAdd($"{TeleNumber}", new Contact(ContactName));
                //}
                //else if (Menu == "showcontact")
                //{
                //    Console.Write("Display contact from phonenumber:");
                //    string userInput = Console.ReadLine();



                //    Contact selectedContact = null;

                //    if (contacts.TryGetValue(userInput, out selectedContact))
                //    {
                //        Console.WriteLine($"Name for this phonenumber is {selectedContact.Name}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Contact not found");
                //    }
                //}
                //else if (Menu == "showall")
                //{
                //    foreach (KeyValuePair<string, Contact> contact in contacts)
                //    {
                //        Console.WriteLine(string.Format("Number: {0}, Name: {1}",
                //            contact.Key, (string)contact.Value));
                //    }
                //}
                //else if (Menu == "searchcontact")
                //{
                //    Console.Write("Display contact from name:");
                //    string userInput = Console.ReadLine();

                //    Contact selectedPhoneNumber = null;
                //    var myKey = contacts.FirstOrDefault(x => x.Value.Name == userInput).Key;
                //    if (contacts.ContainsKey(myKey))
                //    {
                //        Console.WriteLine($"Phonenumber for this phonenumber is {myKey}");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Contact not found");
                //    }


                //}

                //else if (Menu == "quit")
                //{
                //    break;
                //}
                //else
                //{
                //    Console.WriteLine("There isnt option for this input");
                //}

            }



        }
    }
}
