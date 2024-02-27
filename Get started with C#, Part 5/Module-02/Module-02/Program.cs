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
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/2-exercise-add-parameters-to-methods
            // Unit-2
            // Exercise - Use parameters in methods

            // Add parameters to methods
            CountTo(5);

            void CountTo(int max)
            {
                for (int i = 0; i < max; i++)
                {
                    Console.Write($"${i}, ");
                }
            }
            // Continue here:
        }
    }
}
