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
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/3-exercise-remove-if-statements
            // Exercise - Remove code blocks from if statements
            // Create an example of an if statement that uses a code block
            bool flag = true;
            /*
            if (flag)
            {
                Console.WriteLine(flag);
            }
            */
            // update
            if (flag) Console.WriteLine(flag);

            string name = "steve";

            if (name == "bob") 
                Console.WriteLine("Found Bob");
            else if (name == "steve")
                Console.WriteLine("Found Steve");
            else 
                Console.WriteLine("Found Chuck");

            /*
             * Recap
             * Here are a few important things to remember about if statement code blocks and readability:
             * If you realize you have only one line of code listed within the code blocks of an if-elseif-else statement, 
             * you can remove the curly braces of the code block and white space.
             * Microsoft recommends that curly braces be used consistently for all of the code blocks of an if-elseif-else statement 
             * (either present or removed consistently).
             * Only remove the curly braces of a code block when it makes the code more readable. 
             * It's always acceptable to include curly braces.
             * Only remove the line feed if it makes the code more readable. 
             * Microsoft suggests that your code will be more readable when each statement is placed on its own code line.
             */
        }
    }
}
