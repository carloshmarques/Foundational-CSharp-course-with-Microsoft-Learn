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
        {   // Link: https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/4-return-values-input-parameters 

            // Exercise - Return values and input parameters of methods
            // 

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");
        }
    }
}
