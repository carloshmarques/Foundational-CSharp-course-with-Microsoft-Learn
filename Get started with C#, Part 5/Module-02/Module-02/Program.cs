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
            // Create C# methods with parameters
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/

            // Unit-1
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/1-introduction

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
            // Create a method with parameters
            int[] schedule = { 800, 1200, 1600, 2000 };

            DisplayAdjustedTimes(schedule, 6, -6);

            void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
            {
                int diff = 0;
                if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
                {
                    Console.WriteLine("Invalid GMT");
                }
                else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
                {
                    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                }
                else
                {
                    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                }

                for (int i = 0; i < times.Length; i++)
                {
                    int newTime = ((times[i] + diff)) % 2400;
                    Console.WriteLine($"{times[i]} -> {newTime}");
                }

            }
            /*
             * Recap
                Here's what you've learned about parameters so far:

                Information can be passed to methods in the form of parameters.
                Parameters are declared in the method signature.
                Multiple parameters are separated by commas.
                Methods can accept variable or literal arguments.
             */

        }
    }
}
