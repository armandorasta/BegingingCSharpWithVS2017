using System;

using CardLib;

namespace CSharp17;

class Program
{
    public static void Main()
    {
        var arr = new int[20];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }

        foreach (var i in arr.Chunk(10))
        {
            Console.WriteLine(i.Max());
        }
    }

    class Animal : Ss
    {
        public string Name { get; set; }

        public Animal(string name) { Name = name; }

        public void Feed()
        {
            Console.WriteLine($"Animal [{Name}] has been fed.");
        }
    }
}

static class RetRef
{
    public static double AddNumsFromInput()
    {
        Console.Write("Enter four real numbers: ");
        var nums = Console.ReadLine()!.Split();

        var sum = 0.0;
        foreach (var num in nums)
        {
            sum += Double.Parse(num);
        }

        return sum;
    }

    public static string ReverseString(string str)
    {
        string newString = string.Empty;
        for (int i = str.Length - 1; i >= 0; --i)
        {
            newString += str[i];
        }
        return newString;
    }
}

