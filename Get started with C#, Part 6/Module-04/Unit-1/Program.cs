// https://learn.microsoft.com/en-us/training/modules/create-throw-exceptions-c-sharp/

// https://learn.microsoft.com/en-us/training/modules/create-throw-exceptions-c-sharp/1-introduction
// Unit-1

// https://learn.microsoft.com/en-us/training/modules/create-throw-exceptions-c-sharp/2-examine-create-exception-c-sharp
// Unit-2

// Examine how to create and throw exceptions in C#
// Create an exception object

// Configure and throw customized exceptions
try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach(string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    throw;
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }

    }
}

static void BusinessProcess1(string[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}

/*
Things to avoid when throwing exceptions
The following list identifies practices to avoid when throwing exceptions:

Don't use exceptions to change the flow of a program as part of ordinary execution. Use exceptions to report and handle error conditions.
Exceptions shouldn't be returned as a return value or parameter instead of being thrown.
Don't throw System.Exception, System.SystemException, System.NullReferenceException, or System.IndexOutOfRangeException intentionally from your own source code.
Don't create exceptions that can be thrown in debug mode but not release mode. To identify runtime errors during the development phase, use Debug.Assert instead.
*/

/*
Recap
Here are a few important things to remember from this unit:

When creating and throwing an exception, the exception type must match the intended purpose of the exception as closely as possible.
To throw an exception, you create an instance of an exception-derived class, configure its properties, and then use the throw keyword.
When creating an exception object, it's important to provide clear error messages and additional information to help users correct the issue.
*/




