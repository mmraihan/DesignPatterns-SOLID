﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class PersonDataCapture
    {
       
        public static Person Capture()
        {
            Person output = new Person();

            Console.Write("What's your first name ? ");
            output.FirstName = Console.ReadLine();

            Console.Write("What's your last name ? ");
            output.LastName = Console.ReadLine();

            return output;
        }
           
    }
}
