// Use the MinValue and MaxValue properties for each signed integral type

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Use the MinValue and MaxValue properties for each unsigned integral type

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Use the MinValue and MaxValue properties for each signed float type

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Recap

    // A floating-point type is a simple value data type that can hold fractional numbers.
    // Choosing the right floating-point type for your application requires you to consider more than just the maximum and minimum values that it can hold. You must also consider how many values can be preserved after the decimal, how the numbers are stored, and how their internal storage affects the outcome of math operations.
    // Floating-point values can sometimes be represented using "E notation" when the numbers grow especially large.
    // There's a fundamental difference in how the compiler and runtime handle decimal as opposed to float or double, especially when determining how much accuracy is necessary from math operations.

    // Recap

    // Value types can hold smaller values and are stored in the stack. Reference types can hold large values, and a new instance of a reference type is created using the new operator. Reference type variables hold a reference (the memory address) to the actual value stored in the heap.
    // Reference types include arrays, strings, and classes.

// Write code that attempts to add an int and a string and save the result in an int

// int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

// Perform a cast

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// Determine if your conversion is a "widening conversion" or a "narrowing conversion"

// The term narrowing conversion means that you're attempting to convert a value from a data type that can hold more information to a data type that can hold less information. In this case, you may lose information such as precision (that is, the number of values after the decimal point). An example is converting value stored in a variable of type decimal into a variable of type int. If you print the two values, you would possibly notice the loss of information.

// When you know you're performing a narrowing conversion, you need to perform a cast. Casting is an instruction to the C# compiler that you know precision may be lost, but you're willing to accept it.

// Use ToString() to convert a number to a string

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

// Convert a string to an int using the Parse() helper method

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

// Convert a string to a int using the Convert class

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

/* Casting truncates and converting rounds

When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would be the same.

When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. If you changed the literal value to 1.499m, it would be rounded down to 1.

*/

/* Recap

You covered several important concepts of data conversion and casting:

    Prevent a runtime error while performing a data conversion
    Perform an explicit cast to tell the compiler you understand the risk of losing data
    Rely on the compiler to perform an implicit cast when performing an expanding conversion
    Use the () cast operator and the data type to perform a cast (for example, (int)myDecimal)
    Use the Convert class when you want to perform a narrowing conversion, but want to perform rounding, not a truncation of information
*/

// TryParse() a string into an int

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

// Use the parsed int later in code

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

/* Recap

The TryParse() method is a valuable tool. Here are few quick ideas to remember.

    Use TryParse() when converting a string into a numeric data type.
    TryParse() returns true if the conversion is successful, false if it's unsuccessful.
    Out parameters provide a secondary means of a method returning a value. In this case, the out parameter returns the converted value.
    Use the keyword out when passing in an argument to a method that has defined an out parameter.
*/

/* Exercise - Complete a challenge to combine string array values 
as strings and as integers
*/

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

/* Exercise - Complete a challenge to output math 
operations as specific number types */

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// solution

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");