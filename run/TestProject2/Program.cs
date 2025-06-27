// See https://aka.ms/new-console-template for more information


// Formatting strings by adding whitespace before or after
string input = "Pad this";
 //Console.WriteLine(input.PadLeft(12));

//Console.WriteLine(input.PadRight(12));

// What is an overloaded method?

//In C#, an overloaded method is another version of a method with different or extra arguments that modify the functionality of the method slightly, as is the case with the overloaded version of the PadLeft() method.

Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));

//string input = "Pad this 2";
int totalWidth = 20; // Total width of the final string
int padding = (totalWidth - input.Length) / 2;

string result = input.PadLeft(input.Length + padding, '-').PadRight(totalWidth, '-');
Console.WriteLine(result);

/* Working with padded strings

Suppose you work for a payment processing company that still supports legacy mainframe systems. Often, those systems require data to be input in specific columns. For example, store the Payment ID in columns 1 through 6, the payee's name in columns 7 through 30, and the Payment Amount in columns 31 through 40. Also, importantly, the Payment Amount is right-aligned.
*/

// Add the Payment ID to the output

string paymentId = "769C";

 var formattedLine = paymentId.PadRight(6);

 //Console.WriteLine(formattedLine);

// Add the payee name to the output

//string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";

 //var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);

 //Console.WriteLine(formattedLine);

// Add the payment amount to the output

//string paymentId = "769C";
 //string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 //var formattedLine = paymentId.PadRight(6);
 //formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine(formattedLine);

 //Add a line of numbers above the output to more easily confirm the result

 Console.WriteLine("1234567890123456789012345678901234567890");

 /*
 Recap

There's a few important takeaways from this unit.

    The string data type, literal strings, and variables of type string each implement many helper methods to format, modify, and perform other operations on strings.
    The PadLeft() and PadRight() methods add white space (or optionally, another character) to the total length of a string.
    Use PadLeft() to right-align a string.
    Some methods are overloaded, meaning they have multiple versions of the method with different arguments that affect their functionality.
    The += operator concatenates a new string on the right to the existing string on the left.
*/

