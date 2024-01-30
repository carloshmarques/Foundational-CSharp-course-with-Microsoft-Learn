// Module-01 Unit-9
// Conclusion
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, C#!");

// Module-02
// Call methods from the .NET Class Library using C#
// link: https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/

// Exercise - Call the methods of a .NET Class

/*
* Call different kinds of methods in the .NET Class Library
*/

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);