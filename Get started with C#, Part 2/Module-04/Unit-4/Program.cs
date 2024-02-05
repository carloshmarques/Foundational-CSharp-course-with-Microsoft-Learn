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
        {   // https://learn.microsoft.com/en-us/training/modules/csharp-arrays/4-challenge
            // Exercise 
            // Complete a challenge activity for nested iteration and selection statements

            // Code challenge - Report the Order IDs that need further investigation

            // Declare an array and initialize it to contain the following elements:

            /*           
            B123
            C234
            A345
            C15
            B177
            G3003
            C235
            B179
            */

            string[] OrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

            foreach (string orderID in OrderIDs)
            {
              
                if (orderID.StartsWith("B"))
                {
                    Console.WriteLine(orderID);
                }
            }
            
        }
    }
}
