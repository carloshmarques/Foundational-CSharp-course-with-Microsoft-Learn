// Unit-3
// https://learn.microsoft.com/en-us/training/modules/review-principles-code-debugging-exception-handling-c-sharp/3-examine-code-debug

// Examine the code debugger approach to debugging code

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount]);

/*
Recap
Here are a few important things to remember from this unit:

Code debugging is a crucial skill in the software development process that every developer learns.
The best approach to debugging your applications is to use a debugger, 
not rereading your code five times or adding console.WriteLine() statements throughout your code.
Debuggers enable you to pause your application, step through your code line-by-line, 
and observe the state of variables and function parameters.
*/