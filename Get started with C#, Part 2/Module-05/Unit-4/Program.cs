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
            // https://learn.microsoft.com/en-us/training/modules/csharp-readable-code/4-exercise-use-whitespace
            // Exercise - Use whitespace to make your code easier to read

            // Add code to illustrate how whitespace is ignored by the C# compiler

            // Example 1:
            /*
            Console
            .
            WriteLine
            (
            "Hello Example 1!"
            )
            ;

            // Example 2:
            string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");

            // Example of cluttered code
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            */

            // For better readability:

            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            /*
             *  Recap
                The main takeaways from this exercise:

                Use whitespace judiciously to improve the readability of your code.
                Use line feeds to create empty lines to separate phrases of code. A phrase includes lines of code that are similar, or work together.
                Use line feeds to separate code block symbols so that they are on their own line of code.
                Use the tab key to line up a code block with the keyword they're associated with.
                Indent code inside of a code block to show ownership.
             */
        }
    }
}
