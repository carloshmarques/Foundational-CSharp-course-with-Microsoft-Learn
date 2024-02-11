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
            // https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/4-challenge-1
            // 
            // Complete a challenge activity using conditional operators
            /*
             * Code challenge: write code to display the result of a coin flip
             * 
             * Here are your challenge requirements:
             * Use the Random class to generate a value.
             * Consider the range of numbers that is required.
             * Based on the value generated, use the conditional operator to display either heads or tails.
             * There should be a 50% chance that the result is either heads or tails.
             * Your code should be easy to read, but with as few lines as possible.
             * You should be able to accomplish the desired result in three lines of code.
             * Whether you get stuck and need to peek at the solution or you finish successfully, continue on to view a solution to this challenge.
             */
            // Code here:
            Random coin = new Random();
            int coinFlip = coin.Next(0, 2);
            Console.WriteLine((coinFlip == 0) ? "heads" : "tails" );
            // Review the Solution  on: https://learn.microsoft.com/en-us/training/modules/csharp-evaluate-boolean-expressions/5-solution-1


        }
    }
}
