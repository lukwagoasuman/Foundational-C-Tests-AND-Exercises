double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}

/*
Recap

Here's what you've learned about the return keyword so far:

    Methods can return a value by specifying the return data type, or void for no return value
    The return keyword can be used with variables, literals, and expressions
    The value returned from a method must match the specified return type
    Data returned from methods can be captured and used by the caller of the method

*/

/*
Exercise - Return numbers from methods

Create a method that returns an integer

Suppose you're visiting Vietnam and want to create a brief program that converts currency. You can assume the current exchange rate is 1 USD = 23500 VND. In this task, you'll write a method that converts USD to VND.Create a method that returns an integer

Suppose you're visiting Vietnam and want to create a brief program that converts currency. You can assume the current exchange rate is 1 USD = 23500 VND. In this task, you'll write a method that converts USD to VND.

*/

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}

// Exercise - Return strings from methods

/*
Create a method that returns a string

Suppose you're a candidate in a coding interview. The interviewer asks you to write a method to reverse a string without using string.Reverse. Take a moment to think about how you might accomplish this task.
*/

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}

// Exercise - Return Booleans from methods

/*
Create a method that returns a Boolean

Suppose you're a candidate in a coding interview. The interviewer wants you to check if several words are a palindrome. A word is a palindrome if it reads the same backwards and forwards. For example, the word racecar is a palindrome. Let's get started!
*/
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}
bool IsPalindrome(string word) 
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}

// Exercise - Return arrays from methods

// Find coins to make change

int target = 80; // Change this 
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}

/*
Exercise - Complete the challenge to add methods to make the game playable

Dice mini-game challenge

Your challenge is to design a mini-game. 
The game should select a target number that is a random number between one and five (inclusive). 
The player must roll a six-sided dice. To win, the player must roll a number greater than the target number. 
At the end of each round, the player should be asked if they would like to play again, 
and the game should continue or terminate accordingly.
*/

/*
Code challenge: add methods to make the game playable

In the code that you start with, there are two unavailable methods referenced:

    ShouldPlay: This method should retrieve user input and determine if the user wants to play again
    WinOrLose: This method should determine if the player has won or lost

There are also two uninitialized variables:

    target: The random target number between 1 and 5
    roll: The result of a random six-sided die roll

Your challenge should you choose to accept it is to create the ShouldPlay and WinOrLose methods, and create methods that set target 
and roll to random values in the correct range. 
When all the methods are complete, the game should run successfully.
*/

/*
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target;
        var roll;

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}
*/

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}