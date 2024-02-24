using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/4-exercise-split-join
            // Exercise - Discover Split() and Join()
            // String data type's Array methods

            // Use the ToCharArray() to reverse a string
            string value = "abc123";
            char[] valueArray = value.ToCharArray();

            // Reverse, then combine the char array into a new string
            Array.Reverse(valueArray);
            // string result = new string(valueArray);
            string result = String.Join(",", valueArray);
            Console.WriteLine(result);

            // Split() the comma-separated-value string into an array of strings
            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
