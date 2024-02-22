using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intro();

            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2, 5);

            Console.WriteLine("Sentence length: {0}", result);
            Console.WriteLine("Sentence: {0}", sentence);
            Console.WriteLine("Sentence Clone: {0}", result2);
            Console.WriteLine("Sentence endswith 'ğ': {0}", result3);
            Console.WriteLine("Sentence startswith 'My name': {0}", result4);
            Console.WriteLine("Sentence indexof 'name': {0}", result5);
            Console.WriteLine("Sentence indexof ' ': {0}", result6);
            Console.WriteLine("Sentence lastindexof ' ': {0}", result7);
            Console.WriteLine("Sentence insert 'Hello, ' to index 0: {0}", result8);
            Console.WriteLine("Sentence substring, take 4 character from index 3: {0}", result9);
            Console.WriteLine("Sentence tolower: {0}", result10);
            Console.WriteLine("Sentence toupper: {0}", result11);
            Console.WriteLine("Sentence replace ' ' with '-': {0}", result12);
            Console.WriteLine("Sentence remove 5 character from index 2: {0}", result13);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + city2;
            string result2 = String.Format("{0} {1}", city, city2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine("{0} {1}", city, city2);
        }
    }
}
