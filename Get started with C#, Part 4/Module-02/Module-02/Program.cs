using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/

            // Unit-2
            // Exercise - Discover Sort() and Reverse()
            // Create an array of pallets, then sort them

            string[] pallets = { "B14", "A11", "B12", "A13" };
            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets) 
            {
                Console.WriteLine($"-- {pallet}");
            }

            // Reverse the order of the pallets
            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach(var pallet in pallets)
            {
                Console.WriteLine($"--{pallet}");
            }

        }
    }
}
