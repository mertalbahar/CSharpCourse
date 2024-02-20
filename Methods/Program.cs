using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20, 30);
            Console.WriteLine("Add with parameter: {0}", result);

            var result2 = Add3();
            var result3 = Add3(10, 20);
            Console.WriteLine("Add with default parameter: {0}", result2);
            Console.WriteLine("Add with given parameter: {0}", result3);

            int number1 = 20;
            int number2 = 100;
            var result4 = Add4(ref number1, number2);
            Console.WriteLine("number1 with ref keyword: {0}", result4);
            Console.WriteLine("Number1: {0}", number1);

            int number3;
            var result5 = Add5(out number3, number2);
            Console.WriteLine("number3 with out keyword: {0}", result5);
            Console.WriteLine("Number3: {0}", number3);

            Console.WriteLine("Method overloading, multiply 2 number: {0}", Multiply(2,4));
            Console.WriteLine("Method overloading, multiply 3 number: {0}", Multiply(2, 4, 5));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added without parameter");
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Add3(int number1 = 30, int number2 = 30)
        {
            return number1 + number2;
        }

        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add5(out int number3, int number2)
        {
            number3 = 50;
            return number3 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
    }
}
