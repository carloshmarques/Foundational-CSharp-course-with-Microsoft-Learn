using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Link: https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/

            // Write your first C# method
            int[] a = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Contents of Array:");
            PrintArray();

            void PrintArray()
            {
                foreach (int x in a)
                {
                    Console.Write($"{x} ");
                }
                Console.WriteLine();
            }
        }
    }
}
