using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {   // https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/
            // Unit-1
            //  https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/1-introduction
            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/2-string-formatting-basics

            // Exercise - Investigate string formatting basics
            // example of composite formatting( Format method)
            /*
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);
            */

            /*
            string first = "Hello"; 
            string second = "World"; 
            Console.WriteLine("{1} {0}!", first, second); 
            Console.WriteLine("{0} {0} {0}!", first, second);
            */

            // string interpolation
            string first = "Hello"; 
            string second = "World"; 
            Console.WriteLine($"{first} {second}!"); 
            Console.WriteLine($"{second} {first}!"); 
            Console.WriteLine($"{first} {first} {first}!");

            // Formatting currency
            Console.OutputEncoding = Encoding.UTF8;
            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            // Formatting           
            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");

            // Formatting percentages
            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");

            // Combining formatting approaches
            decimal productPrice = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (productPrice - salePrice), productPrice);
            yourDiscount += $"A discount of {((productPrice - salePrice) / productPrice):P2}!"; //inserted
            Console.WriteLine(yourDiscount);





        }

    }
}
