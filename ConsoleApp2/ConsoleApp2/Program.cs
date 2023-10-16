using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "AI Conversation";
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("Hello, I am RX:001, an AI chatbot from future. \nWhat's your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {userName}! \nAre you learning C# ? (yes/no)");
            string userLearning = Console.ReadLine();

            if (userLearning != null) {
                if (userLearning.ToLower() == "yes")
                {
                    Console.WriteLine("Cool! Watch out of bugs. Unless they're gonna kill your code! \nHappy coding!");
                    Console.ReadKey();
                }
                else if (userLearning.ToLower() == "no")
                {
                    Console.WriteLine("Don't play around, go learn it now!");
                    Console.ReadKey();
                }
                else { Console.WriteLine("It was a yes/no question. Bye!");
                    Console.ReadKey();
                }
            }
        }
    }
}
