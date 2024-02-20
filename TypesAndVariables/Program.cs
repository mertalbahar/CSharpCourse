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
            int number1 = -2147483648; // min value for int
            int number2 = 2147483647; // max value for int
            Console.WriteLine("Number1 is {0} and Number2 is {1}", number1, number2);
            Console.ReadLine();
        }
    }
}
