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
            byte number7 = 0; // min value for byte, 8 bit
            byte number8 = 255; // min value for byte, 8 bit

            Console.WriteLine("byte(8) min '{0}' and byte max '{1}'\n", number7, number8);

            short number5 = -32768; // min value for short, 16 bit
            short number6 = 32767; // max value for short, 16 bit

            Console.WriteLine("short(16) min '{0}' and short max '{1}'\n", number5, number6);

            int number1 = -2147483648; // min value for int, 32 bit
            int number2 = 2147483647; // max value for int, 32 bit
            Console.WriteLine("int(32) min '{0}' and int max '{1}'\n", number1, number2);

            long number3 = -9223372036854775808; // min value for long, 64 bit
            long number4 = 9223372036854775807; // max value for long, 64 bit
            Console.WriteLine("long(64) min '{0}' and long max '{1}'\n", number3, number4);

            bool condition1 = true;
            bool condition2 = false;
            Console.WriteLine("bool for condition '{0}' or '{1}'\n", condition1, condition2);

            char character = 'A'; // Keeps ASCII characters.
            Console.WriteLine("char for keeping ASCII characters like '{0}'\n", character);

            double number9 = 10.4;
            Console.WriteLine("double(64) for decimal '{0}'\n", number9); // double for decimal and keeps 16 character after comma, 64 bit

            decimal number10 = 10.4m;
            Console.WriteLine("decimal(128) for decimal '{0}'\n", number10); // decimal for decimal and keeps 29 character after comma, 128 bit

            // 0f for float
            // 0d for double
            // 0m for decimal (money)
            // 0u for unsigned int
            // 0l for long
            // ul for unsigned long

            Console.ReadLine();
        }
    }
}
