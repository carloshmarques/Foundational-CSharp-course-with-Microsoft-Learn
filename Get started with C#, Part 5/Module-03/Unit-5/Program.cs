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
            // https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-return-values/5-exercise-create-methods-return-booleans
            // Exercise - Return Booleans from methods

            // Create a method that returns a Boolean
            string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

            Console.WriteLine("Is it a palindrome?");
            foreach (string word in words)
            {
                Console.WriteLine($"{word}: {IsPalindrome(word)}");
            }
            bool IsPalindrome(string word)
            {
                int start = 0;
                int end = word.Length - 1;

                while (start < end)
                {
                    if (word[start] != word[end])
                    {
                        return false;
                    }
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}
