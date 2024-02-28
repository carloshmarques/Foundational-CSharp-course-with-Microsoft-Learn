using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-6/

            // Unit-1
            // https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/1-introduction

            // Unit-2
            // https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/2-get-started-test-debug-exception

            // Get started with testing, debugging, and exception handling
            // Consider the following sample code:
            string[] students = new string[] { "Sophia", "Nicolas", "Zahirah", "Jeong" };

            int studentCount = students.Length;

            Console.WriteLine("The final name is: " + students[studentCount]);

            /*
             * The code sample is intended to accomplish the following:
             * Declare a string array named students. 
             * The students array contains the names of students.
             * Declare an integer named studentCount. 
             * The code uses the Length method of the array to assign a value to studentCount.
             * Print the name of the final student to the console. 
             * The code uses studentCount to access the final name in the students array, 
             * and it uses the Console.WriteLine() method to print the information to the console.
             */

            /*
             * Recap
             * Here are a few important things to remember from this unit:
             * Testing, debugging, and exception handling are all important tasks for software developers.
             * Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
             * Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
             * Exception handling is the process of managing errors that occur during runtime, 
             * and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
             */



        }
    }
}
