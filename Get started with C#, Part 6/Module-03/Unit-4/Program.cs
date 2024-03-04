// https://learn.microsoft.com/en-us/training/modules/implement-exception-handling-c-sharp/4-exercise-try-catch

// Exercise - Implement try-catch exception handling
try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

/*
Recap
Here are a few important things to remember from this unit:

Implement a try-catch pattern to try specified code lines within your application and catch exceptions that occur within the scope of the try code block.
Use a catch clause to catch an exception thrown at the same level of the call stack.
Use a catch clause to catch an exception thrown at a higher level of the call stack.
*/