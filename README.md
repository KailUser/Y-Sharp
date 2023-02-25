
# YSHARP Library

YSHARP is a simple library for C# that provides some basic functions for console input/output, thread management, and math operations.


## Usage

To use the YSHARP library in your C# project, follow these steps:

    Add the YSHARP.cs file to your project.
    Import the YSHARP namespace in your code: using YSHARP;
    Use the available functions as needed. The following functions are currently available:
## YSHARP.Print(string message)

Prints a message to the console.

```csharp
YSHARP.Print("Hello, world!");
```
## YSHARP.Round(double value, int digits)

Rounds a double value to the specified number of decimal digits.
```csharp
double result = YSHARP.Round(3.14159, 2); // result is 3.14
```
## YSHARP.Range(int start, int end)

Generates an array of integers from a start value (inclusive) to an end value (exclusive).

```csharp
int[] numbers = YSHARP.Range(1, 5); // numbers is {1, 2, 3, 4}
```
## YSHARP.Clear()

Clears the console screen.

```csharp
YSHARP.Clear();
```
## YSHARP.GetUserInput(string prompt)

Prompts the user for input and returns the input as a string.

```csharp
string name = YSHARP.GetUserInput("Enter your name: ");
```
## YSHARP.Wait(int milliseconds)

Pauses the program execution for the specified number of milliseconds.

```csharp
YSHARP.Wait(1000); // wait for 1 second
```
## YSHARP.ToInt(string value)
Converts a string value to an integer. If the string is not a valid integer, an error message is printed to the console and 0 is returned.

```csharp
int number = YSHARP.ToInt("42"); // number is 42
```
## YSHARP.ToString(int value)

Converts an integer value to a string.

```csharp
int number = 42;
string numberString = YSHARP.ToString(number); // numberString is "42"
```
