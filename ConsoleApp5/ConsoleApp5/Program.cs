using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Device
    {
        public string name;
        public double price;
        private int count;
        public static int DeviceCount; //when we add static to a variable, it is shared by all the instances of a class

        //class constructor
        public Device(string _name, double _price, int _count)
        {
            name = _name;
            price = _price;
            count = _count;
            DeviceCount++;
        }

        public void sellDevice()
        {
            Console.Write($"Number of {name}s to sell: ");
            int sellCount = Convert.ToInt32(Console.ReadLine());
            if (sellCount > 0 && sellCount <= count)
            {
                int stock = count - sellCount;
                count = stock;
                Console.WriteLine($"Sold {sellCount} {name}{(sellCount > 1 ? "s" : "")}! {count} {name}{(count > 1 ? "s are" : " is")} in stock.\n");
            }
            else if (sellCount > 0 && sellCount > count)
            {
                int extra = sellCount - count;
                Console.WriteLine($"Oops! You have {count} {name}{(count > 1 ? "s" : "")} in stock. You have to wait for the extra {extra} {name}{(extra > 1 ? "s" : "")} to re-stock!\n");
            }
            else 
            { 
                Console.WriteLine("Invalid number\n");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Device Store";
            Console.WindowHeight = 40;

            Console.Write("Enter Device Information before selling them.\n");
            Device device1 = AddDevice();
            Device device2 = AddDevice();

            //access static variable
            Console.WriteLine($"\nYou have {Device.DeviceCount} type{(Device.DeviceCount > 1 ? "s" : "")} of device{(Device.DeviceCount > 1 ? "s" : "")} in stock to sell.\n");
            
            
            Console.ForegroundColor = ConsoleColor.Green;
            device1.sellDevice();
            device1.sellDevice();
            device1.sellDevice();

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            device2.sellDevice();
            device2.sellDevice();
            device2.sellDevice();

            Console.ResetColor();

        }

        //method or function
        static Device AddDevice()
        {
            Console.Write("\nEnter Device Name: ");
            string deviceName = Console.ReadLine();

            Console.Write("Unit price: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Count: ");
            int deviceCount = Convert.ToInt32(Console.ReadLine());

            Device device = new Device(deviceName, unitPrice, deviceCount);
            return device;
        }
    }
}
