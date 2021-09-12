using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessage.WelcomeMessage();
            

            Person user = PersonDataCapture.Capture();


            bool isUserValid = PersonValidator.Validate(user);
            if (isUserValid==false)
            {
                StandardMessage.EndApplication();
            }

            AccountGenerator.CreateAccount(user);
            StandardMessage.EndApplication();

           
        }
    }
}
