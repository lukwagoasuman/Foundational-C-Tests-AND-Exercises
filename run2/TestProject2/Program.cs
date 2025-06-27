// Exercise - Use value and reference type parameters

/*
Parameters passed by value and passed by reference

When an argument is passed to a method, value type variables have their values copied into the method. Each variable has its own copy of the value, so the original variable isn't modified.

With reference types, the address of the value is passed into the method. The variable given to the method references the value at that address, so operations on that variable affect the value that is referenced by the other.
*/

// Test pass by value

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

// Test pass by reference

int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) 
{
    foreach (int a in array) 
    {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = 0;
    }
}

// Test with strings

// Earlier, you learned that strings are an immutable type. Even though a string is a reference type, unlike an array, its value can't be altered once it's assigned. You might have noticed this if you've used methods such as string.Replace or string.ToUpper. In this task, you'll learn to correct a common error found when working with strings.

/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
*/

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) 
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}

/*
Recap

Here's what you've learned about value type and reference type parameters so far:

    Variables can be categorized as value types and reference types.
    Value types directly contain values, and reference types store the address of the value.
    Methods using value type arguments create their own copy of the values.
    Methods that perform changes on an array parameter affect the original input array.
    String is an immutable reference type.
    Methods that perform changes on a string parameter don't affect the original string.


*/

// Exercise - Methods with optional parameters

// Create an RSVP application

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
//RSVP("Linh", 2, "none", false);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
//RSVP("Tony", 1, "Jackfruit", true);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
//RSVP("Noor", 4, "none", false);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

//void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        if (inviteOnly)
{
    bool found = false;
    foreach (string guest in guestList)
    {
        if (guest.Equals(name)) {
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Sorry, {name} is not on the guest list");
        return;
    }
}
        // search guestList before adding rsvp
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

/*
Recap

Here's what you've learned about optional and named arguments so far:

    Parameters are made optional by setting a default value in the method signature.
    Named arguments are specified with the parameter name, followed by a colon and the argument value.
    When combining named and positional arguments, you must use the correct order of parameters.
*/