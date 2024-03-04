// https://learn.microsoft.com/en-us/training/modules/implement-visual-studio-code-debugging-tools/8-exercise-monitor-variables-execution-flow

// Configure your application and launch configuration 
string? readResult;
int startIndex = 0;
bool goodEntry = false;

int[] numbers = { 1, 2, 3, 4, 5 };

// Display the array to the console.
Console.Clear();
Console.Write("\n\rThe 'numbers' array contains: { ");
foreach (int number in numbers)
{
    Console.Write($"{number} ");
}

// To calculate a sum of array elements, 
//  prompt the user for the starting element number.
Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
while (goodEntry == false)
{
    readResult = Console.ReadLine();
    goodEntry = int.TryParse(readResult, out startIndex);

    if (startIndex > 5)
    {
        goodEntry = false;
        Console.WriteLine("\n\rEnter an integer value between 1 and 5");
    }
}

// Display the sum and then pause.
Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex -1)}");

Console.WriteLine("press Enter to exit");
readResult = Console.ReadLine();

// This method returns the sum of elements n through 5
static int SumValues(int[] numbers, int n)
{
    int sum = 0;
    for (int i = n; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }
    return sum;
}

// Monitor watch expressions
bool exit = false;
var rand = new Random();
int num1 = 5;
int num2 = 5;

do
{
    num1 = rand.Next(1, 11);
    num2 = num1 + rand.Next(1, 51);

} while (exit == false);
/*
Recap
Here are a few important things to remember from this unit:

Monitor variable state using the VARIABLES section of the RUN AND DEBUG view.
Track an expression across time or different methods using the WATCH section of the RUN AND DEBUG view.
Use the CALL STACK section of the RUN AND DEBUG view to find the source location of an exception or a WATCH expression.
Use the VARIABLES section to change a variable's assigned value at runtime.
*/