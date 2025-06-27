// Examine how to create and throw exceptions in C#

/*
.NET provides a hierarchy of exception classes that derive from the System.Exception base class. 
C# applications can create and throw exceptions of any exception type. 
Developers can also customize exception objects with application specific information by assigning property values.
*/

/*
When to throw an exception

Methods should throw an exception whenever they can't complete their intended purpose. 
The exception thrown should be based on the most specific exception available that fits the error conditions.
*/

/*
Re-throwing exceptions

In addition to throwing a new exception, throw can be used re-throw an exception from inside a catch code block. 
In this case, throw does not take an exception operand.

When you re-throw an exception, the original exception object is used, so you don't lose any information about the exception. If you want to create a new exception object that wraps the original exception, you can pass the original exception as an argument to the constructor of a new exception object. 
For example:
catch (Exception ex)
{
    // handle or partially handle the exception
    // ...

    // create a new exception object that wraps the original exception
    throw new ApplicationException("An error occurred", ex);
}
*/

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



