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
            // https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/3-exercise-create-your-first-method
            // Exercise - Create your first method
            // Create a method to display random numbers

            // Call your method
            Console.WriteLine("Generating random numbers:");
            DisplayRandomNumbers();

            void DisplayRandomNumbers()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++) 
                {
                   Console.Write($"{random.Next(1, 100)} ");
                }
                Console.WriteLine();
            }

            /*
             *  Recap
                Here's what you've learned about methods so far:

                Create a method by declaring the return type, name, input parameters, and method body.
                Method names should clearly reflect the task the method performs.
                Use a method by calling its name and including parentheses ().
             */

        }
    }
}
