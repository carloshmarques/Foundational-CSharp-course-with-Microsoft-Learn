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
            // Link: https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/


            // Unit-2
            // Understand the syntax of methods
            // https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/2-understand-syntax-of-methods

            // Write your first C# method
            int[] a = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Contents of Array:");
            PrintArray();

            void PrintArray()
            {
                foreach (int x in a)
                {
                    Console.Write($"{x} ");
                }
                Console.WriteLine();
            }

            // Method execution
            Console.WriteLine("Before calling a method");
            SayHello();
            Console.WriteLine("After calling a method");

            void SayHello()
            {
                Console.WriteLine("Hello World!");
            }

            /*
             *  Best practices
             *  When choosing a method name, 
             *  it's important to keep the name concise and make it clear what task the method performs.
             *  Method names should be Pascal case and generally shouldn't start with digits. 
             *  Names for parameters should describe what kind of information the parameter represents.
             *  Consider the following method signatures:
             */

             void ShowData(string a, int b, int c)
            {

            }
             void DisplayDate(string month, int day, int year)
            {

            }


        }
    }
}
