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
            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 7) break;
            }
            */

            // Loop through each element of an array
            /*
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            */

            // Overcoming the limitation of the foreach statement using the for statement
            string[] names = { "Alex", "Eddie", "David", "Michael" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            /*
             *  Recap
             *  Here are a few of the takeaways from this unit:
             *  The for iteration statement allows you to iterate through a block of code a specific number of times.
             *  The for iteration statement allows you to control every aspect of the iteration's mechanics by 
             *  altering the three conditions inside the parentheses: the initializer, condition, and iterator.
             *  It's common to use the for statement when you need to control how you want to iterate through each item in an array.
             *  If your code block has only one line of code, 
             *  you can eliminate the curly braces and white space if you wish.
             */
        }
    }
}
