using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3];

            Console.Title = "Sort Names";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Enter 3 names: ");
            
            for (int i = 0; i < names.Length; i++)
            {
                string name = Console.ReadLine();
                names[i] = name;
            }

            string namesString = string.Join(", ", names);
            Console.WriteLine($"Names to sort: {namesString}");

            Console.WriteLine("Press Enter to sort them!");
            Console.ReadKey();

            Array.Sort(names);
            string sortedNamesString = string.Join(", ", names);
            Console.WriteLine($"Sorted Names: {sortedNamesString}");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("\nEnter a sentence to see the word count: ");
            string sentence = Console.ReadLine();
            int count = sentence.Split().Length;
            Console.WriteLine($"There are {count} words in your sentence.");
            Console.ReadKey();

        }
    }
}
