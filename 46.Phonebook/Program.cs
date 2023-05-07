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
                Console.WriteLine("Select number:");
                Console.WriteLine("1. Add contact to phonebook");
                Console.WriteLine("2. Show all contacts from phonebook");
                Console.WriteLine("3. Show name of contact from number");
                Console.WriteLine("4. Show number from contact name):");
                Console.WriteLine("5. Quit");
                string Menu = Console.ReadLine().ToLower();
                switch (Menu)
                {
                    case "1":                        
                        ContactRepository.AddNewContact(contacts);
                        break;
                    case "2":
                        ContactRepository.ShowAllContacts(contacts);
                        break;
                    case "3":
                        ContactRepository.ShowContact(contacts);
                        break;
                    case "4":
                        ContactRepository.SearchContacts(contacts);
                        break;
                    case "5":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("There isn't option for this input");
                        break;
                        
                        


                }




            }



        }
    }
}
