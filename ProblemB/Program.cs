using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string firstLine = Console.ReadLine();
        int n = int.Parse(firstLine);

        string secondLine = Console.ReadLine();
        int[] numbers = secondLine.Split(' ').Select(int.Parse).ToArray();

        Array.Sort(numbers);

        Console.WriteLine("First Line: " + firstLine);
        Console.WriteLine("Second Line: " + secondLine);

        Console.WriteLine("Numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
