// https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-6/

// Review the principles of code debugging and exception handling
// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/

// Unit-1
// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/1-introduction


// Unit-2
// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/2-get-started-test-debug-exception
// Get started with testing, debugging, and exception handling

/*
Code debugging and developer responsibilities
Code debugging is a process that developers use to isolate an issue and identify one or more ways to fix it. 
The issue could be related to either code logic or an exception. 
Either way, you work on debugging your code when it isn't working the way you want it to. 
Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate. 
Therefore, fixing syntax issues such as a missing ";" at the end of a code statement, isn't normally considered debugging.
*/

// Consider the following sample code:
string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount]);
/* This line of code will throw:

Exception has occurred: CLR/System.IndexOutOfRangeException
An unhandled exception of type 'System.IndexOutOfRangeException' occurred in Unit-1.dll: 'Index was outside the bounds of the array.'
 at Program.<Main>$(String[] args) in c:\Users\carlo\OneDrive\Documentos\Github\master\Foundational-CSharp-course-with-Microsoft-Learn\Get started with C#, Part 6\Module-01\Unit-1\Program.cs:line 28
*/


/*
Exception handling and developer responsibilities
As you read earlier, errors that occur during the application runtime are referred to as exceptions. 
If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.

Handling exceptions is definitely a responsibility of the developer. 
C# provides a way for you to "try" the code that you know might generate an exception, and a way for you to "catch" any exceptions that do occur.

Recap
Here are a few important things to remember from this unit:

Testing, debugging, and exception handling are all important tasks for software developers.
Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
Exception handling is the process of managing errors that occur during runtime, 
and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
*/