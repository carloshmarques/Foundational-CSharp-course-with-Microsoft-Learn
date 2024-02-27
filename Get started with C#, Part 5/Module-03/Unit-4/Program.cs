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
            // Exercise - Return strings from methods
            // Create a method that returns a string

            // Test your code:
            string input = "there are snakes at the zoo";

            Console.WriteLine(input);
            Console.WriteLine(ReverseSentence(input));           
        }
        static string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }
            return result.Trim();
        }

        static string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }



    }
}
