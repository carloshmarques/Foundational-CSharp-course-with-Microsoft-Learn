using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Link: https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/4-return-values-input-parameters 

            // Exercise - Return values and input parameters of methods
            // In the previous unit,
            // you used a "roll dice" coding scenario to illustrate
            // the difference between stateful (instance) and stateless (static) methods.
            //

            // That same scenario can help you to understand other important concepts about calling methods. For example:
            // handling the return value of a method.
            // passing input parameters to a method.
            // choosing an overloaded version of a method.

            //Return values
            //Some methods are designed to complete their function and end "quietly".
            //In other words, they don't return a value when they finish.
            //They are referred to as void methods.
            //
            //Other methods are designed to return a value upon completion.
            //The return value is typically the result of an operation.
            //A return value is the primary way for a method to communicate back to the code that calls the method.
            //You saw that the Random.Next() method returns an int type containing the value of the randomly generated number.
            //However, a method can be designed to return any data type,
            //even another class.
            //For example, the String class has some methods that return a string,
            //some that return an integer, and some that return a Boolean.
            //When calling a method that returns a value,
            //you'll often assign the return value to a variable.
            //That way, you can use the value later in your code.
            //In the dice scenario, you assigned the return value of Random.Next() to the roll variable:

            /*
             * Random dice = new Random();
             * 
               int roll = dice.Next(1, 7);
             * In some cases, you might want to use the return value directly, without assigning it to a variable. 
             * For example, you might want to print the return value to the console as follows:
               Console.WriteLine(dice.Next(1, 7));
            
            Even though a method returns a value, it's possible to call the method without using the return value. 
            For example, you could ignore the return value by calling the method as follows:

            dice.Next(1, 7);
            However, ignoring the return value would be pointless. 
            The reason you're calling the Next() method is so that you can retrieve the next random value.
             */

            // Input parameters

            /*
             *  The information consumed by a method is called a parameter. A method can use one or more parameters to accomplish its task, or none at all.
             *  
             *  Note
             *  Often times, the terms 'parameter' and 'argument' are used interchangeably. 
             *  However, 'parameter' refers to the variable that's being used inside the method. 
             *  An 'argument' is the value that's passed when the method is called.
             *  
             *  Most methods are designed to accept one or more input parameters. 
             *  The input parameters can be used to configure how the method performs its work, or they might be operated on directly. 
             *  
             *  For example, 
             *  the Random.Next() method uses input parameters to configure the upper and lower boundaries of the return value. 
             *  However, the Console.WriteLine() uses the input parameter directly by printing the value to the console.
             *  Methods use a method signature to define the number of input parameters that the method will accept, 
             *  as well as the data type of each parameter. 
             *  The coding statement that calls the method must adhere the requirements specified by the method signature. 
             *  Some methods provide options for the number and type of parameters that the method accepts.
             *  
             *  When a caller invokes the method, 
             *  it provides concrete values, called arguments, for each parameter.
             *  The arguments must be compatible with the parameter type.
             *  However, the argument name, 
             *  if one is used in the calling code, doesn't have to be the same as the parameter named defined in the method.

                Consider the following code:

                C#

                Copy
                Random dice = new Random();
                int roll = dice.Next(1, 7);
                Console.WriteLine(roll);
            
            The first code line creates an instance of the Random class named dice. 
            The second code line uses the dice.Next(1, 7) method to assign a random value to an integer named roll. 
            Notice that the calling statement provides two arguments separated by a , symbol. 
            The Next() method includes a method signature that accepts two input parameters of type int. T
            hese parameters are used to configure the lower and upper boundaries for the random number that's returned. 
            The final code line uses the Console.WriteLine() method to print the value of roll to the console.
            The arguments passed to a method must be the same data type as the corresponding input parameters defined by the method. 
            If you attempt to pass an incorrectly typed argument to a method, 
            the C# compiler will catch your mistake and force you to update your calling statement before your code will compile and run. 
            Type checking is one way that C# and .NET use to prevent end-users from experiencing errors at runtime.
            
            Note
            Although input parameters are often used, not all methods require input parameters to complete their task. 

            For example, the Console class includes a Console.Clear() method that doesn't use input parameters. 
            Since this method is used to clear any information displayed in the console, 
            it doesn't need input parameters to complete it's task.

             */

            // Overloaded methods
            // Many methods in the.NET Class Library have overloaded method signatures.
            // Among other things, this enables you to call the method with or without arguments specified in the calling statement.
            //
            // An overloaded method is defined with multiple method signatures.
            // Overloaded methods provide different ways to call the method or provide different types of data.
            // In some cases, overloaded versions of a method are used to define an input parameter using different data types.
            //
            // For example, the Console.WriteLine() method has 19 different overloaded versions.
            // Most of those overloads allow the method to accept different types and then write the specified information to the console.
            // Consider the following code:
            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            /*
             * In this example, you're invoking three separate overloaded versions of the WriteLine() method.
             * The first WriteLine() method uses a method signature that defines an int parameter.
             * The second WriteLine() method uses a method signature that defines zero input parameters.
             * The third WriteLine() method uses a method signature that defines a string parameter.
             * In other cases, overloaded versions of a method define a different number of input parameters. 
             * The alternative input parameters can be used to provide more control over desired result. 
             * For example, 
             * the Random.Next() method has overloaded versions that enable you to set various levels of constraint on the randomly generated number.
             */

            // To examine the overloaded versions of the Random.Next() method, enter the following code
            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            /*
             * Take a minute to examine the code.
             * The first version of the Next() method doesn't set an upper and lower boundary, 
             * so the method will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.
             * 
             * The second version of the Next() method specifies the maximum value as an upper boundary, 
             * so in this case, you can expect a random value between 0 and 100.
             * 
             * The third version of the Next() method specifies both the minimum and maximum values,
             * so in this case, you can expect a random value between 50 and 100.        
             */

            /*
             * Recap
             * 
             * Methods might accept no parameters or multiple parameters, 
             * depending on how they were designed and implemented.
             * When passing in multiple input parameters, separate them with a , symbol.
             * 
             * Methods might return a value when they complete their task, or they might return nothing (void).
             * Overloaded methods support several implementations of the method, 
             * each with a unique method signature (the number of input parameters and the data type of each input parameter).
             * 
             * IntelliSense can help write code more quickly. 
             * It provides a quick reference to methods, their return values, their overloaded versions, and the types of their input parameters.
             * learn.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work.
             */
        }
    }
}
