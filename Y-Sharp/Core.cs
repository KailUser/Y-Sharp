using System;
using System.Linq;
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

    public static string[] Split(string value, char delimiter)
    {
        return value.Split(delimiter);
    }

    public static string Join(string[] values, string delimiter)
    {
        return string.Join(delimiter, values);
    }

    public static string Strip(string value)
    {
        return value.Trim();
    }

    public static string Replace(string value, string oldValue, string newValue)
    {
        return value.Replace(oldValue, newValue);
    }

    public static void Enumerate<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Print(i + ": " + array[i]);
        }
    }

    public static void Zip<T1, T2>(T1[] array1, T2[] array2)
    {
        for (int i = 0; i < array1.Length && i < array2.Length; i++)
        {
            Print($"({array1[i]}, {array2[i]})");
        }
    }

    public static T[] Sorted<T>(T[] array) where T : IComparable<T>
    {
        return array.OrderBy(x => x).ToArray();
    }

    public static T[] Reversed<T>(T[] array)
    {
        return array.Reverse().ToArray();
    }

    public static int Sum(int[] array)
    {
        return array.Sum();
    }

    public static int Max(int[] array)
    {
        return array.Max();
    }

    public static int Min(int[] array)
    {
        return array.Min();
    }

    public static int Len<T>(T[] array)
    {
        return array.Length;
    }
}