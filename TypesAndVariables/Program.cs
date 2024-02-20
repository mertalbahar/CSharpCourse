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
            short number5 = -32768; // min value for short, 16 bit
            short number6 = 32767; // max value for short, 16 bit

            Console.WriteLine("Short(16) min {0} and Short max {1}", number5, number6);

            int number1 = -2147483648; // min value for int, 32 bit
            int number2 = 2147483647; // max value for int, 32 bit
            Console.WriteLine("int(32) min {0} and int max {1}", number1, number2);

            long number3 = -9223372036854775808; // min value for long, 64 bit
            long number4 = 9223372036854775807; // max value for long, 64 bit
            Console.WriteLine("long(64) min {0} and long max {1}", number3, number4);

            Console.ReadLine();
        }
    }
}
