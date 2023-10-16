using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Average Calculator";
            Console.ForegroundColor = ConsoleColor.Yellow;

            double num1, num2, num3, average;

            Console.Write("Input first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input third number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            average = (num1 + num2 + num3) / 3;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"The average of your inputs is: {average}");
            Console.ResetColor();


            Console.ReadKey();
        }
    }
}
