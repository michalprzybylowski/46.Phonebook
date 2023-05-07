using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Contact
    {
        public Contact(string name) 
        {
            Name = name;
        }
        /*public override string ToString()
        {
            return $"{Name}, ";
        }
        */
        public static implicit operator string(Contact contact) { return $"{contact.Name}, {contact.FirstName}"; }
        public string Name { get; set; }
        public string FirstName { get; set; }

    }
}
