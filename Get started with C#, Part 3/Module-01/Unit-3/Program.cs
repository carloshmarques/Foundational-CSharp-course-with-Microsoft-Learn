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
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/3-exercise-conditional-operator

            // Implement the conditional operator

            // Add code that uses a conditional operator
            int saleAmount = 1001;
            //int discount = saleAmount > 1000 ? 100 : 50;

            // Use the conditional operator inline

            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            /*
             * Recap
             * You should remember the following facts about the conditional operator:
             * You can use the conditional operator to reduce the size of your code, 
             * but you should ensure that the resulting code is easily readable.
             * You can use the conditional operator when you need to return a value that's based on a binary condition. 
             * Your code will return the first option when the condition evaluates to true, 
             * and it will return the second option when the condition evaluates to false.
             */
        }
    }
}
