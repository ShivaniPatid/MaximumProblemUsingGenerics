using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a option to find a maximum number : ");
            Console.WriteLine(" 1. Find 3 integer maximum number");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    IntegerMaximumNumber integerMaximumNumber = new IntegerMaximumNumber();
                    int value = integerMaximumNumber.PrintIntegerMaximumNumber(40, 50, 30);
                    Console.WriteLine("Maximum Number Of Integer is " + value);
                    break;
                default:
                    Console.WriteLine("Chosse a right number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
