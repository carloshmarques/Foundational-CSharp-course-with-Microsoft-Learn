using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   // https://learn.microsoft.com/en-us/training/modules/csharp-arrays/3-exercise-foreach
            // Exercise - Implement the foreach statement

            // Create and initialize an array of int

            int[] inventory = { 200, 450, 700, 175, 250 };

            // Add a variable to sum the value of each element in the array
            int sum = 0;

            // Create a variable to hold the current bin number and display the running total
            int bin = 0;

            // Add a foreach statement to iterate through the array
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

            }
            Console.WriteLine($"We have {sum} items in inventory.");

        }
    }
}
