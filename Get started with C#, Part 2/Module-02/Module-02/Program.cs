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

            // Exercise - Call the methods of a .NET Class

            /*
            *  From your previous experience with the Console.WriteLine() method, 
            *  you should already know the basics:
            *  Start by typing the class name. In this case, the class name is Console.
            *  Add the member access operator, the . symbol.
            *  Add the method's name. In this case, the method's name is WriteLine.
            *  Add the method invocation operator, which is a set of parentheses ().
            *  Finally, specify the arguments that are passed to the method, 
            *  if there are any, between the parentheses of the method invocation operator. 
            *  In this case, you specify the text that you want the Console.WriteLine() method to write to the console 
            *  (for example, "Hello World!").
            *  Optionally, 
            *  depending on how the developers designed and implemented the given method, you may also need to:
            *  
            *  Pass additional values as input parameters.
            *  Accept a return value.
            *  In the next unit, 
            *  you'll examine how to pass input values to a method,
            *  and how a method can be used to return a value to the calling routine.
            *  
            *  While some methods can be called the same way that you called Console.WriteLine(), 
            *  there are other methods in the .NET Class Library that require a different approach.
            */

            // Call different kinds of methods in the .NET Class Library
            // Create a code sample that implements methods of the System.Random and System.Console classes

            Random dice = new Random();
            // This code simulates a dice roll using the Random.Next() method to generate a number,
            // and the Console.WriteLine() method to display the value.
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            /*
             * On the third code line,
             * you include a reference to the Console class and call the Console.WriteLine() method directly. 
             * However, you use a different technique for calling the Random.Next() method. 
             * The reason why you're using two different techniques is because some methods are stateful and others are stateless. 
             * Your next step is to examine the difference between stateful and stateless methods.
             * 
             */

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
