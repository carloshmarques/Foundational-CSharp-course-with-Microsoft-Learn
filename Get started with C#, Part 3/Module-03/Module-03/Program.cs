using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-switch-case/
            // Branch the flow of code using the switch-case construct in C#
            // Unit-1
            // https://learn.microsoft.com/en-us/training/modules/csharp-switch-case/1-introduction
            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/csharp-switch-case/2-exercise-switch-case

            // Exercise - Implement a switch statement
            // Create and test a switch statement
            // Code here:
            int employeeLevel = 200;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");

            // Continue: tomorrow

        }
    }
}
