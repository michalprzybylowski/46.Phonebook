namespace Phonebook
{
    public class AddNewContact
    {

        public static void addNewContact(Dictionary<string, Contact> contacts)
        {
            Console.Write("Write your number:");
            string TeleNumber = Console.ReadLine();
            Console.Write("Write your contact name:");
            string ContactName = Console.ReadLine();
            contacts.TryAdd($"{TeleNumber}", new Contact(ContactName));
        }
    }
}