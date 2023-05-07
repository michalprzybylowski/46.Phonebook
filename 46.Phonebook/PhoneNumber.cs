using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class PhoneNumber
    {
        private string contactNumber;
        public PhoneNumber(string ContactNumber)
        {
            ContactNumber = contactNumber;
        }
        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact Number");
                }
                else
                {
                    contactNumber = value;
                }

            }

        }

        
    }
}
