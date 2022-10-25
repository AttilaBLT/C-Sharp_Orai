using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat___01
{
    public class NamePhoneNumberEmailAddress
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public NamePhoneNumberEmailAddress()
        {
        }

        public NamePhoneNumberEmailAddress(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
