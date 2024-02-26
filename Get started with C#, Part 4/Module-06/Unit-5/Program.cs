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
            // https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/5-exercise-challenge-extract-replace-remove-data
            //Exercise: Complete a challenge to extract, replace, and remove data from an input string

            // Extract, replace, and remove data from an input string
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            // extract "quantity"
            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int quantityStart = input.IndexOf(openSpan) + openSpan.Length // + length of <span> so index at end of <span> tag
            int quantityEnd = input.IndexOf(closeSpan);
            int quantityLength = quantityEnd - quantityStart;
            quantity = $"Quantity: {quantity}";

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            const string tradeSymbol = "&trade;";
            const string regSymbol = "&reg;";
            output = input.Replace(tradeSymbol, regSymbol);

            // Remove the opening <div> tag
            const string openDiv = "<div>";
            int divStart = output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);

            // Remove the closing </div> tag and add "Output:" to the beginning
            const string closeDiv = "</div>";
            int divCloseStart = output.IndexOf(closeDiv);
            output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            Console.WriteLine(quantity);
            Console.WriteLine(output);
          
        }
    }
}
