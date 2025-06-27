// See https://aka.ms/new-console-template for more information

//Exercise - Use the Remove() and Replace() methods

/*Use the Remove() method

You would typically use Remove() when there's a standard and consistent position of the characters you want to remove from the string.
*/

//Remove characters in specific locations from a string

string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

/* Use the Replace() method

The Replace() method is used when you need to replace one or more characters with a different character (or no character). The Replace() method is different from the other methods used so far, it replaces every instance of the given characters, not just the first or last instance.
*/

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);

/*
Recap

Here are two important things to remember:

    The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
    The Replace() method swaps all instances of a string with a new string.
*/

/* Exercise - Complete a challenge to extract, replace, and remove data from an input string

Extract, replace, and remove data from an input string

*/

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);

