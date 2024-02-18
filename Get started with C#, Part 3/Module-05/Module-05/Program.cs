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
            // https://learn.microsoft.com/en-us/training/modules/csharp-do-while/
            // Add looping logic to your code using the do-while and while statements in C#

            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/csharp-do-while/2-exercise-do-while-continue

            // Exercise - Create do and while iteration loops
            /*
             * On the surface, 
             * the do-while and while statements,
             * are yet another iteration statement that allows you to iterate through a code block
             * and thereby change the flow of execution of your code. 
             * However, once we examine how each works,
             * we can better identify the nuances of each iteration statement and when to use them.
             */

            // Exercise:
            // Write a do-while statement to break when a certain random number is generated

            Random random = new Random();
            int current = random.Next(1, 11);
            /*
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            }   while (current != 7);
            */
            /*
            while (current > 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */

            do
            {
                current = random.Next(1, 11);
                if(current >=8) 
                    continue;

                Console.WriteLine(current);

            }while (current != 7);

            /*
             * Recap
             * There's a few important ideas you should take away from this unit:
             * The do-while statement iterates through a code block at least once, 
             * and might continue to iterate based on a Boolean expression. 
             * The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
             * The while statement evaluates a Boolean expression first, 
             * and continues to iterate through the code block as long as the Boolean expression evaluates to true.
             * The continue keyword to step immediately to the Boolean expression.
             */
        }
    }
}
