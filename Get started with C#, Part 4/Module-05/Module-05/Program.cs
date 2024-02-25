using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/
            // Convert data types using casting and conversion techniques in C#

            // Unit-2
            // Exercise - Explore data type casting and conversion
            // https://learn.microsoft.com/en-us/training/modules/csharp-convert-cast/2-exercise-data-type-conversion

            // Write code that attempts to add an int and a string and save the result in an int
            int first = 2;
            string second = "4";
            // int result = first + second;
            string result = first + second;
            Console.WriteLine(result);

            // Is it possible that attempting to change the value's data type would result in a loss of information?
            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            // Perform a cast
            myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            // Determine if your conversion is a "widening conversion" or a "narrowing conversion"
            myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float  : {myFloat}");

            // Use ToString() to convert a number to a string
            int myfirst = 5;
            int mysecond = 7;
            string message = myfirst.ToString() + mysecond.ToString();
            Console.WriteLine(message);

            // Convert a string to an int using the Parse() helper method
            string First = "5";
            string Second = "7";
            int sum = int.Parse(First) + int.Parse(Second);
            Console.WriteLine(sum);

            // Convert a string to a int using the Convert class
            string myString = "5";
            string mySecondString = "6";
            int operation= Convert.ToInt32(myString) * Convert.ToInt32(mySecondString);
            Console.WriteLine(operation);

            // Compare casting and converting a decimal into an int
            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value2 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value2);
        }

    }
}
