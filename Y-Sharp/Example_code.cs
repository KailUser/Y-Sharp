using System;
using System.Collections.Generic;
using System.Text;

public class Example
{
    public static void Main()
    {
        bool a = YSHARP.Equals(20, 20);
        bool b = YSHARP.Equals(20, 30);
        YSHARP.Print("Hello, World!");
        string user = YSHARP.GetUserInput("Your name: ");
        YSHARP.Clear();
        YSHARP.Print("Hello, " + user + "!");
        YSHARP.Print("Result: a Equals: 20 = 20 " + a + "\n        b Equals: 20 = 30 " + b);
        YSHARP.Wait(20000);
    }

}