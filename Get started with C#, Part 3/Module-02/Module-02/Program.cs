using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/
            // Unit-2
            // Link: https://learn.microsoft.com/en-us/training/modules/csharp-code-blocks/2-exercise-variable-scope

            // Exercise - Code blocks and variable scope

            // Create a variable inside of a code block
            bool flag = true;
            int value = 0;
            if (flag)
            {
                
                Console.WriteLine($"Inside the code block: {value}");
            }
            value = 10;
            Console.WriteLine($"Outside the code block: {value}");

        }
    }
}
