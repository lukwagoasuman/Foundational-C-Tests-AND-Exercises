// See https://aka.ms/new-console-template for more information

// Exercise - Use the string's IndexOf() and Substring() helper methods

// Write code to find parenthesis pairs embedded in a string

//string message = "Find what is (inside the parentheses)";

//int openingPosition = message.IndexOf('(');
//int closingPosition = message.IndexOf(')');

//openingPosition += 1;

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

//string message = "What is the value <span>between the tags</span>?";

//int openingPosition = message.IndexOf("<span>");
//int closingPosition = message.IndexOf("</span>");

//openingPosition += 6;
//int length = closingPosition - openingPosition;
//Console.WriteLine(message.Substring(openingPosition, length));

// Avoid magic values

// Hardcoded strings like "<span>" in the previous code listing are known as "magic strings" and hardcoded numeric values like 6 are known as "magic numbers". These "Magic" values are undesirable for many reasons and you should try to avoid them if possible.

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

/* Recap

This unit covered much material. Here's the most important things to remember:

    IndexOf() gives you the first position of a character or string inside of another string.
    IndexOf() returns -1 if it can't find a match.
    Substring() returns just the specified portion of a string, using a starting position and optional length.
    There's often more than one way to solve a problem. You used two separate techniques to find all instances of a given character or string.
    Avoid hardcoded magic values. Instead, define a const variable. A constant variable's value can't be changed after initialization.
*/

/* Exercise - Use the string's IndexOf() and LastIndexOf() helper methods
*/

string message1 = "hello there!";

int first_h = message1.IndexOf('h');
int last_h = message1.LastIndexOf('h');

Console.WriteLine($"For the message: '{message1}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// Retrieve the last occurrence of a sub string

string message2 = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition1 = message2.LastIndexOf('(');

openingPosition1 += 1;
int closingPosition1 = message2.LastIndexOf(')');
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message2.Substring(openingPosition1, length1));

// Retrieve all instances of substrings inside parentheses

string message3 = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition2 = message3.IndexOf('(');
    if (openingPosition2 == -1) break;

    openingPosition2 += 1;
    int closingPosition2 = message3.IndexOf(')');
    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(message3.Substring(openingPosition2, length2));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message3 = message3.Substring(closingPosition2 + 1);
}

string message4 = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message4.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message4[index]}' in '{message4}' at index: {index}.");

