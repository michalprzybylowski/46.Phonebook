namespace Phonebook
{
    internal class ContactRepository
    {
        
        public static void AddNewContact(Dictionary<string, Contact> contacts)
        {
            Console.Write("Write your number:");
            string TeleNumber = Console.ReadLine();
            Console.Write("Write your contact name:");
            string ContactName = Console.ReadLine();
            contacts.TryAdd($"{TeleNumber}", new Contact(ContactName));
        }

        public static void ShowContact(Dictionary<string, Contact> contacts)
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
        public static void ShowAllContacts(Dictionary<string, Contact> contacts)
        {
            foreach (KeyValuePair<string, Contact> contact in contacts)
            {
                Console.WriteLine(string.Format("Number: {0}, Name: {1}",
                    contact.Key, (string)contact.Value));
            }
        }
        public static void SearchContacts(Dictionary<string, Contact> contacts)
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
        
    }
}