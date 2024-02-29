// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/
// Review the principles of code debugging and exception handling

// Unit-1/ Intoduction
// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/1-introduction


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

// Console.WriteLine("The final name is: " + students[studentCount]);
Console.WriteLine("The final name is: " + students[studentCount -1]);

/*
*Recap
Here are a few important things to remember from this unit:

Testing, debugging, and exception handling are all important tasks for software developers.
Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.
*/
