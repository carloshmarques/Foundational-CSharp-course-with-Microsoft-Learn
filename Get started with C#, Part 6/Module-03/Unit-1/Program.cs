// https://learn.microsoft.com/en-us/training/modules/implement-exception-handling-c-sharp/

// Unit-2
// https://learn.microsoft.com/en-us/training/modules/implement-exception-handling-c-sharp/2-examine-exceptions-exception-handling-process
// Examine exceptions and the exception handling process

try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{   
   // Step 5: the system transfers control to the first line of the catch code block
}

/*
Recap
Here are a few important things to remember from this unit:

Common scenarios that may require exception handling include user input, data processing, file I/O operations, database operations, and network communication.
Exception handling in C# is implemented using try, catch, and finally keywords. Each keyword has an associated code block that serves a specific purpose.
Exceptions are represented as types and derived from the System.Exception class in .NET. Exceptions contain information that identifies the type of exception, and properties that provide additional details.
When an exception occurs, the .NET runtime searches for the nearest catch clause that can handle it. The search starts with the method where the exception was thrown, and moves down the call stack if necessary.
*/
