using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ForLoop();

            // WhileLoop();

            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 10);

            Console.ReadLine();
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
