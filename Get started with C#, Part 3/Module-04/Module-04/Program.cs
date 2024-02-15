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
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-for/
            // Unit-2
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-for/2-exercise-for
            // Exercise - Create and configure for iteration loops
            // Write a basic for statement

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            // Change the iteration conditions

            /*
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            // Experiment with the iterator's pattern
            /*
            for (int i = 0; i < 10; i += 3)
            {
                Console.WriteLine(i);
            }
            */

            // Use the break keyword to break the iteration statement
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }

            // Loop through each element of an array

            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }

            // Overcoming the limitation of the foreach statement using the for statement
            // Continue here:
        }
    }
}
