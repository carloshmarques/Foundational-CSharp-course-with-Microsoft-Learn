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
            // Call methods from the .NET Class Library using C#
            // link: https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/

            // Unit-3
            // Call different kinds of methods in the .NET Class Library

            // Creating an instance of a class
            // An instance of a class is called an object.
            // To create a new instance of a class, you use the new operator.
            // Consider the following line of code that creates a new instance of the Random class to create a new object called dice:
            Random dice = new Random();
            /*
             * The new operator does several important things:
             * It first requests an address in the computer's memory large enough to store a new object based on the Random class.
             * It creates the new object, and stores it at the memory address.
             * It returns the memory address so that it can be saved in the dice variable.
             * From that point on, when the dice variable is referenced,
             * the .NET Runtime performs a lookup behind the scenes to give the illusion that you're working directly with the object itself.
             */

            // How can you determine whether you need to create an instance of a class before calling its methods?
            // Accessing the Random.Next() method:
            int roll = dice.Next(1, 7);

            // Display the code to console.
            Console.WriteLine(roll);
            /*
             *  Recap
             *  
             *  To call methods of a class in the .NET Class Library, 
             *  you use the format ClassName.MethodName(), 
             *  where the . symbol is the member access operator to access a method defined on the class, 
             *  and the () symbols are the method invocation operators.
             *  When calling a stateless method, you don't need to create a new instance of its class first.
             *  When calling a stateful method, you need to create an instance of the class, and access the method on the object.
             *  Use the new operator to create a new instance of a class.
             *  An instance of a class is called an object.
             */
        }
    }
}
