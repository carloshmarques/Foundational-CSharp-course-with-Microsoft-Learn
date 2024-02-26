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
            void DisplayRandomNumbers()
            {
                Random random = new Random();

                for (int i = 0; i < 5; i++) 
                {
                   Console.Write($"{random.Next(1, 100)} ");
                }
                Console.WriteLine();
            }

        }
    }
}
