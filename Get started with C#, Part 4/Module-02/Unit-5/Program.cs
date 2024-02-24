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
            // Exercise - Complete a challenge to reverse words in a sentence
            // https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/5-challenge-1
            
            // Write code to reverse each word in a message
            string pangram = "The quick brown fox jumps over the lazy dog";

            // Code must produce the following output:
            // ehT kciuq nworb xof spmuj revo eht yzal god

            string[] message = pangram.Split(' ');

            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
        }
    }
}
