﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 11;

            if (number == 10)
            {
                Console.WriteLine("Number is: 10\n");
                
            }
            else
            {
                Console.WriteLine("Number is not 10\n");
            }

            Console.WriteLine(number == 10 ? "Number is: 10\n" : "Number is not 10\n");

            Console.ReadLine();
        }
    }
}
