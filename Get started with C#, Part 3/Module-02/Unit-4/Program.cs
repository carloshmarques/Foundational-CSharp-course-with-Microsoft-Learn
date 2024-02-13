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
            // https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/4-exercise-challenge-variable-scope
            // Exercise - Complete a challenge activity using variable scope

            // Code challenge: update problematic code in the code editor
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0; // Initialize total outside the loop
            bool found = false; // Initialize found outside the loop

            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                {
                    found = true;
                }
            }
            // Now you can use the variables 'total' and 'found' outside the loop

            if (found)
            {
                Console.WriteLine("Set contains 42");

            }

            Console.WriteLine($"Total: {total}");
        }
    }
}
