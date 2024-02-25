using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/6-challenge-2
            // Unit-6

            // Exercise - Complete a challenge to output math operations as specific number types
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            // Your code here to set result1
            // Hint: You need to round the result to nearest integer (don't just truncate)
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            // Your code here to set result2
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            // Your code here to set result3
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
        }
    }
}
