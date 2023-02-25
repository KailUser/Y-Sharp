using System;
using System.Collections.Generic;
using System.Text;

public class Example
{
    public static void Main()
    {
        YSHARP.Print("Hello, World!");
        YSHARP.Wait(1000);
        YSHARP.Print("What is your name?");
        string input = YSHARP.GetUserInput("Name: ");
        YSHARP.Print("Hello, " + input + "!");
        YSHARP.Print("Equals 20 = 30: " + Return().ToString());
        YSHARP.Print("Equals 30 = 30: " + Return2().ToString());
        YSHARP.GetUserInput('Waiting for Enter key')
    }

    private static string Return()
    {
        return Equals(20, 30).ToString();
    }
    private static string Return2()
    {
        return Equals(30, 30).ToString();
    }
}