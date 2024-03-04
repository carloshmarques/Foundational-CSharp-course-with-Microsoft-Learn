// https://learn.microsoft.com/en-us/training/modules/create-throw-exceptions-c-sharp/3-exercise-create-throw-exception-c-sharp

// Exercise - Create and throw an exception
// Prompt the user for the lower and upper bounds

/*
This is a C# program that calculates the average of even numbers between two bounds. 
The user is prompted to enter the lower and upper bounds. 
The program then calculates the average of all even numbers within these bounds using the AverageOfEvenNumbers function.
If the lower bound is greater than or equal to the upper bound, 
an ArgumentOutOfRangeException is thrown. 
The program catches this exception and prompts the user to enter a new upper bound until a valid one is provided.
*/

Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());

Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;
bool exit = false;
do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");
        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;

        }
        else
        {
             exit = false;
            upperBound = int.Parse(userResponse);
        }
    }
} while (exit == false);


// Wait for user input
Console.ReadLine();

static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{   
    if (lowerBound >= upperBound)
    {
        throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
    }
    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}

/*
Recap
Here are a few important things to remember from this unit:

Ensure that your debug environment is configured to support your application requirements.
Method code should throw an exception when an issue or condition is detected.
Exceptions should be caught at a level in the call stack where they can be resolved.
*/