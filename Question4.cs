/*What is Composite Formatting?

Composite formatting uses numbered placeholders within a string. At run time, everything inside the braces is resolved to a value that is also passed in based on their position.
*/

string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

/* What is string interpolation?

String interpolation is a technique that simplifies composite formatting.
*/

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

/*
Formatting currency

Composite formatting and string interpolation can be used to format values for display given a specific language and culture.
*/

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

/* Formatting numbers

When working with numeric data, you might want to format the number for readability by including commas to delineate thousands, millions, billions, and so on.
*/

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

/* Formatting percentages

Use the P format specifier to format percentages and rounds to 2 decimal places. Add a number afterwards to control the number of values displayed after the decimal point. Update your code as follows:
*/

/* | Feature             | `file.cpp`                         | `file.cs`                           |
| ------------------- | ---------------------------------- | ----------------------------------- |
| Language            | C++                                | C#                                  |
| Language Type       | Compiled, lower-level              | Compiled (to IL), higher-level      |
| Used For            | System-level apps, games, embedded | Windows apps, web apps, services    |
| Compiler            | `g++`, `clang++`                   | `csc`, `dotnet` (for .NET projects) |
| Entry Point Example | `int main()`                       | `static void Main(string[] args)`   |
| Platform            | Native code (e.g., Windows, Linux) | .NET/.NET Core platform             |
*/

/* Formatting percentages

Use the P format specifier to format percentages and rounds to 2 decimal places. Add a number afterwards to control the number of values displayed after the decimal point. Update your code as follows:
*/

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

/* Combining formatting approaches

String variables can store strings created using formatting techniques. In the following example, decimals and decimal math results are formatted and stored in the yourDiscount string using composite formatting.
*/

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscount);

// Updated code
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);

