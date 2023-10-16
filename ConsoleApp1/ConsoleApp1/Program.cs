using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first program
            Console.WriteLine("Hello World!");

            //variables - string, int, float, double, bool, char
            string text = "Initial value: ";
            int i = 100;
            Console.WriteLine(text + i); //string concatenation

            //using functions
            TestFunction();
            bool a = TestFunction2(i);
            bool b = TestFunction3(i);
            Console.WriteLine(a);
            Console.WriteLine(b);

            //conditions
            if (!a && !b)
            {
                Console.WriteLine("Value of i is 100");
            }
            else
            {
                Console.WriteLine("Value of i is not equal to 100");
            }

            //switch-case
            string result;
            switch (i)
            {
                case 100:
                    result = "Value of i is 100";
                    break;
                default:
                    result = "Value of i is not equal to 100";
                    break;
            }
            Console.WriteLine(result);

            //collections - arrays, lists
            int[] intArray = new int[] { 0, 1, 2, 3, 4, 5 }; //fixed size collection: Array
            Console.WriteLine("Array with length: " + intArray.Length);

            List<int> numberList = new List<int>() { 0, 1, 2, 3, 4 }; //dynamic size collection: List
            Console.WriteLine("List with count: " + numberList.Count);

            numberList.Add(5);
            Console.WriteLine("Count after adding an element: " + numberList.Count);

            numberList.Remove(0);
            Console.WriteLine("Count after removing an element: " + numberList.Count);

            //loops (for any collection) - foreach, for, while, do-while
            List<int> squaredNumbers = numberList.Select(x => Convert.ToInt32(Math.Pow(x, 2))).ToList(); //using LINQ (Language Integrated Query)

            foreach (int number in squaredNumbers)
            {
                Console.WriteLine(number);
            }

            foreach (int p in numberList)
            {
                Console.WriteLine(p);
            }

            for (int p = 0; p < numberList.Count; p++)
            {
                Console.WriteLine("Index: " + p + ", Element: " + numberList[p]);
            }

            int q = 0;
            while (q < intArray.Length)
            {
                Console.WriteLine("Index: " + q + ", Element: " + intArray[q]);
                q++;
            }

            int r = 0;
            do
            {
                Console.WriteLine("Index: " + r + ", Element: " + intArray[r]);
                r++;
            }
            while (r < intArray.Length);

            //use classes
            MyClass myClass = new MyClass();
            int accessMyInt = myClass.myInt;
            accessMyInt = 5;
            Console.WriteLine("Accessed myInt:" +  accessMyInt);



            //keep the console open for any keypress
            Console.ReadKey();
        }

        //functions
        static void TestFunction() { } //a void function without any parameter and a return value

        //funtions with parameters and return values
        static bool TestFunction2(int i)
        {
            return i < 100;
        }
        static bool TestFunction3(int i)
        {
            return i > 100;
        }

        //enums (custom type definition)
        enum ComponentType //enumeration of certain specific values
        {
            Server,
            Client
        }

        static ComponentType component;

        static void Test(string[] args)
        {
            switch (component)
            {
                case ComponentType.Server:
                    break;
                case ComponentType.Client:
                    break;
            }
        }

        //classes
        class MyClass{
            //we can define anything here

            //accessors - public, private (default: private)
            bool myBoolean; //only accessible within this class scope
            public int myInt; //accessible anywhere

            public void myFunction()
            {
                //execute something
                myBoolean = true;
            }

            public MyClass() {
                //custom constructor
            }
        }

        //scopes - global, block

    }
}
