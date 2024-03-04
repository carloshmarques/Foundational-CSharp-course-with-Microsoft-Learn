// https://learn.microsoft.com/en-us/training/modules/implement-exception-handling-c-sharp/5-exercise-challenge-try-catch
// Exercise - Complete a challenge activity for try-catch

// Try-Catch challenge
// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue = 0;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

/*
Recap
Here are a few important things to remember from this unit:

The catch clause should be configured to catch a specific exception type. For example, the DivideByZeroException exception type.
The properties of an exception object can be accessed within the catch block. For example, you can use the Message property to inform the application user of an issue.
You can specify two or more catch clauses when you need to catch more than one exception type.
*/