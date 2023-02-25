using System;
using System.Threading;

public class YSHARP
{
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }

    public static double Round(double value, int digits)
    {
        return Math.Round(value, digits);
    }

    public static int[] Range(int start, int end)
    {
        int[] range = new int[end - start];
        for (int i = 0; i < range.Length; i++)
        {
            range[i] = start + i;
        }
        return range;
    }

    public static void Clear()
    {
        Console.Clear();
    }

    public static string GetUserInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    public static void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public static int ToInt(string value)
    {
        int result;
        if (!int.TryParse(value, out result))
        {
            Print("Invalid input");
        }
        return result;
    }

    public static string ToString(int value)
    {
        return value.ToString();
    }
}