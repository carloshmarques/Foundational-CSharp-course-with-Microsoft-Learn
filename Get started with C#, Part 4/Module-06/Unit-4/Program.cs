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
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/4-exercise-remove-replace
            // Exercise - Use the Remove() and Replace() methods

            // Use the Remove() method
            // Remove characters in specific locations from a string
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            // Use the Replace() method
            // Remove characters no matter where they appear in a string
            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);

            /*
             * Recap
                Here are two important things to remember:
                The Remove() method works like the Substring() method,
                except that it deletes the specified characters in the string.
                The Replace() method swaps all instances of a string with a new string.
             */

        }
    }
}
