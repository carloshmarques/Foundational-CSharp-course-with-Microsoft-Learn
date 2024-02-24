using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-format-strings/4-exercise-string-methods-padding

            // Exercise - Discover padding and alignment
            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            Console.WriteLine(result);

            // Formatting strings by adding whitespace before or after
            string input = "Pad this";

            // Before
            Console.WriteLine(input.PadLeft(12));

            // after
            Console.WriteLine(input.PadRight(12));

            // overloaded method
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            // Working with padded strings
            // Add the Payment ID to the output
            Console.WriteLine(string.Empty);

            string paymentId = "769C";
            // Add the payee name to the output
            string payeeName = "Mr. Stephen Ortega";
            // Add the payment amount to the output
            string paymentAmount = "$5,000.00";


            var formattedLine = paymentId.PadRight(6);
            // concatenate previus value variable formattedLine
            // with += operator to
            // to add new value 
            formattedLine = formattedLine + payeeName.PadRight(24);

            // concatenate previus value variable formattedLine
            // with += operator to
            // to add new value 
            formattedLine += paymentAmount.PadLeft(10);

            // Add a line of numbers above the output to more easily confirm the result
            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);


        }
    }
}
