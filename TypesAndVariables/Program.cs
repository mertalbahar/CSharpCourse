using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            int number1 = -2147483648; // min value for int, 32 bit
            int number2 = 2147483647; // max value for int, 32 bit
            Console.WriteLine("Number1 is {0} and Number2 is {1}", number1, number2);

            long number3 = -9223372036854775808; // min value for long, 64 bit
            long number4 = 9223372036854775807; // max value for long, 64 bit
            Console.WriteLine("Number3 is {0} and Number4 is {1}", number3, number4);

            Console.ReadLine();
        }
    }
}
