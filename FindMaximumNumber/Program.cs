using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine(" 1. Find integer maximum number among 3 numbers\n 2. Find float maximum number among 3 numbers\n 3 . Find maximum string among 3 strings");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    IntegerMaximumNumber integerMaximumNumber = new IntegerMaximumNumber();
                    int intValue = integerMaximumNumber.PrintIntegerMaximumNumber(70, 85, 60);
                    Console.WriteLine("Maximum number of integer is "+intValue);
                    break;
                case 2:
                    FloatMaximumNumber floatMaximumNumber = new FloatMaximumNumber();
                    float floatValue = floatMaximumNumber.PrintFloatMaximumNumber(77.5f, 99.9f,  16.07f);
                    Console.WriteLine("Maximum number of float is "+floatValue);
                    break;
                case 3:
                    MaximumString maximumString = new MaximumString();
                    string strvalue = maximumString.PrintMaximumString("Apple", "Banana", "Peach");
                    Console.WriteLine("Maximum string is "+strvalue);
                    break;
                default:
                    Console.WriteLine("Chosse a right number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
