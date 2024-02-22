using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productrManager = new ProductManager();
            productrManager.Add();
            productrManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";
            customer.City = "Ankara";

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Derin",
                LastName = "Demiroğ",
                City = "İstanbul"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
