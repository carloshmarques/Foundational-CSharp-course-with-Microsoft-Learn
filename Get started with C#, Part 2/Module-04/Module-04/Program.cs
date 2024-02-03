using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-arrays/
            // Store and iterate through sequences of data using Arrays and the foreach statement in C#

            // Declare a new array
            // string[] fraudulentOrderIDs = new string[3];

            // Initialize an array
            string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

            // Assign values to elements of an array
            //fraudulentOrderIDs[0] = "A123";
            //fraudulentOrderIDs[1] = "B456";
            //fraudulentOrderIDs[2] = "C789";

            // Retrieve values from elements of an array
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"First: {fraudulentOrderIDs[1]}"); 
            Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

            // Reassign the value of an array
            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            // Use the Length property of an array
            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        }
    }
}
