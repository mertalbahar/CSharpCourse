using System;
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
            else if (number == 20)
            {
                Console.WriteLine("Number is: 20\n");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20\n");
            }

            Console.WriteLine(number == 10 ? "Number is: 10\n" : "Number is not 10\n");

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is: 10\n");
                    break;
                case 20:
                    Console.WriteLine("Number is: 20\n");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20\n");
                    break;
            }

            Console.ReadLine();
        }
    }
}
