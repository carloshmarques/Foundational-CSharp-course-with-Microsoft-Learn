using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-choose-data-type/5-exercise-reference-types
            // Exercise - Discover reference types
            // Define a reference type variable
            // int[] data;

            int[] data = new int[3];

            /*
             * What's different about the C# string data type?
             * The string data type is also a reference type. 
             * You might be wondering why a new operator wasn't used when declaring a string. 
             * This is purely a convenience afforded by the designers of C#. 
             * Because the string data type is used so frequently, you can use this format:
             */

            string shortenedString = "Hello World!";
            Console.WriteLine(shortenedString);

        }
    }
}
