using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class PersonValidator
    {
        public static bool Validate(Person person)
        {
            //Check to be sure first and last name are valid

            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessage.DispplayValidationError("first name");
               
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessage.DispplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
 