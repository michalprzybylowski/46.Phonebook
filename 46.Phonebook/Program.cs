using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Program : AddNewContact
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

            

            while (true)
            {
                Console.WriteLine("Select what do you want to do(Add, ShowAll, ShowContact, SearchContact, Quit ):");
                string Menu = Console.ReadLine().ToLower();

                    

                if (Menu == "add")
                {
                    Console.Write("Write your number:");
                    string TeleNumber = Console.ReadLine();
                    Console.Write("Write your contact name:");
                    string ContactName = Console.ReadLine();
                    contacts.TryAdd($"{TeleNumber}", new Contact(ContactName));
                }
                else if (Menu == "showcontact")
                {
                    Console.Write("Display contact from phonenumber:");
                    string userInput = Console.ReadLine();



                    Contact selectedContact = null;

                    if (contacts.TryGetValue(userInput, out selectedContact))
                    {
                        Console.WriteLine($"Name for this phonenumber is {selectedContact.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found");
                    }
                }
                else if (Menu == "ShowAll")
                {
                    foreach (KeyValuePair<string, Contact> contact in contacts)
                    {
                        Console.WriteLine(string.Format("Key: {0}, Value: {1}",
                            contact.Key, (string)contact.Value));
                    }
                }
                else if (Menu == "SearchContact")
                {
                    Console.Write("Display contact from name:");
                    string userInput = Console.ReadLine();

                    Contact selectedPhoneNumber = null;
                    var myKey = contacts.FirstOrDefault(x => x.Value.Name == userInput).Key;
                    if (contacts.ContainsKey(myKey))
                    {
                        Console.WriteLine($"Phonenumber for this phonenumber is {myKey}");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found");
                    }
                    

                }
                
                else if (Menu == "Quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("There isnt option for this input");
                }

            }



        }
    }
}
