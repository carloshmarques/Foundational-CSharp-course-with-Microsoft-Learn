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
            // link  https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-4/
            // Work with variable data in C# console applications (Get started with C#, Part 4)

            // Choose the correct data type in your C# code
            // https://learn.microsoft.com/en-us/training/modules/csharp-choose-data-type/

            // Unit-3
            // Exercise - Discover integral types
            // https://learn.microsoft.com/en-us/training/modules/csharp-choose-data-type/3-exercise-integral-types

            // Use the MinValue and MaxValue properties for each signed integral type
            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            // Use the MinValue and MaxValue properties for each unsigned integral type
            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        }
    }
}
