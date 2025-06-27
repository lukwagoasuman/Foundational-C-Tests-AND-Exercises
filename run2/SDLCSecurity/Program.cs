/*
Learning objectives

In this module, you will:

    Review the responsibilities for software testing, debugging, and exception handling.
    Examine the code debugging process and the benefits provided by code debugger tools.
    Examine what an exception is and the options for managing exceptions in your code.
*/

/*
Software testing categories can be organized under the types of testing, the approaches to testing, or a combination of both. One way to categorize the types of testing is to split testing into Functional and Nonfunctional testing. The functional and nonfunctional categories each include subcategories of testing. For example, functional and nonfunctional testing could be divided into the following subcategories:

    Functional testing - Unit testing - Integration testing - System testing - Acceptance testing
    Nonfunctional testing - Security testing - Performance testing - Usability testing - Compatibility testing

Although most developers probably don't consider themselves to be testers, some level of testing is expected before a developer hands off their work. When developers are assigned a formal role in the testing process, it's often at the level of unit testing.
*/

/*
Code debugging and developer responsibilities

Code debugging is a process that developers use to isolate an issue and identify one or more ways to fix it. The issue could be related to either code logic or an exception. Either way, you work on debugging your code when it isn't working the way you want it to. Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate. Therefore, fixing syntax issues such as a missing ";" at the end of a code statement, isn't normally considered debugging.


*/

string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

Console.WriteLine("The final name is: " + students[studentCount]);

/*
The code sample is intended to accomplish the following:

    Declare a string array named students. The students array contains the names of students.
    Declare an integer named studentCount. The code uses the Length method of the array to assign a value to studentCount.
    Print the name of the final student to the console. The code uses studentCount to access the final name in the students array, and it uses the Console.WriteLine() method to print the information to the console.

At first glance, everything seems fine. However, this code generates an exception when attempting to print the student name to the console. The developer forgot that arrays are zero-based. The final name in the array should be accessed using students[studentCount - 1].

Code debugging is definitely a developer responsibility. In this code sample, you may have recognized the issue right away. However, in more complex coding scenarios, finding an issue isn't always easy. Don't worry, there are tools and approaches that you can use to track down issues that're hard to find.
*/

/*
Exception handling and developer responsibilities

As you read earlier, errors that occur during the application runtime are referred to as exceptions. If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.

Handling exceptions is definitely a responsibility of the developer. C# provides a way for you to "try" the code that you know might generate an exception, and a way for you to "catch" any exceptions that do occur.
Recap

Here are a few important things to remember from this unit:

    Testing, debugging, and exception handling are all important tasks for software developers.
    Testing can be categorized into functional and nonfunctional testing, and developers are expected to perform some level of testing.
    Code debugging is the process of isolating issues and identifying ways to fix them, and it's a developer responsibility.
    Exception handling is the process of managing errors that occur during runtime, and developers are responsible for handling exceptions by using "try" and "catch" statements in their code.

*/

/*
Recap

Here are a few important things to remember from this unit:

    Code debugging is a crucial skill in the software development process that every developer learns.
    The best approach to debugging your applications is to use a debugger, not rereading your code five times or adding console.WriteLine() statements throughout your code.
    Debuggers enable you to pause your application, step through your code line-by-line, and observe the state of variables and function parameters.
*/

// Examine exceptions and how exceptions are used

// What are exceptions?

/*
In C#, errors in the program at runtime are propagated through the program by using a mechanism called exceptions. 
Exceptions are thrown by code that encounters an error and caught by code that can correct the error. 
Exceptions can be thrown by the .NET runtime or by code in a program. 
Exceptions are represented by classes derived from Exception. 
Each class identifies the type of exception and contains properties that have details about the exception.
*/

/*
What does it mean to "throw" and "catch" an exception?

The terms "throw" and "catch" can be explained by evaluating the definition of an exception.

The second sentence of the definition says "Exceptions are thrown by code that encounters an error and caught by code that can correct the error". The first part of this sentence tells you that exceptions are created by the .NET runtime when an error occurs in your code. The second part of the sentence tells you that you can write code to catch an exception that's been thrown. In addition, the code that catches the exception can be used to complete a corrective action, hopefully mitigating the situation caused by the code that resulted in the error. In other words, you can write code that protects your application when an error occurs.
*/

/*
Recap

Here are a few important things to remember from this unit:

    Exceptions are used in C# to propagate errors at runtime, and are represented by classes derived from the Exception class.
    Exceptions are thrown by code that encounters an error and caught by code that can correct the error.
    When an exception is caught, code can access its contents and take corrective action to mitigate the error.
    The .NET runtime generates exceptions when it detects an error and the exception contains information about the type of error that occurred.
*/

