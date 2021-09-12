using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public  class StandardMessage
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my Application");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DispplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give us a valid {fieldName}!");
        }
    }
}
