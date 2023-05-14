using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string numberOfBuses = Console.ReadLine();
        // string numberOfBuses = "8";
        int n = int.Parse(numberOfBuses);

        string buses = Console.ReadLine();
        // string buses = "181 180 141 174 143 142 175 171 172";
        int[] numbers = buses.Split(' ').Select(int.Parse).ToArray();

        Array.Sort(numbers);

        FindConsecutiveValues(numbers, n);
    }

    public static void FindConsecutiveValues(int[] buses, int n)
    {
        int start = buses[0];
        int end = buses[0];

        for (int i = 1; i < buses.Length; i++)
        {
            if (buses[i] - buses[i - 1] == 1)
            {
                end = buses[i];
            }
            else
            {
                if (start != end && end - start != 1)
                {
                    Console.Write($"{start}-{end} ");
                }
                else if (start != end)
                {
                    Console.Write($"{start} {end} ");
                }
                else
                {
                    Console.Write($"{start} ");
                }

                start = buses[i];
                end = buses[i];
            }
        }

        // final iteration
        if (start != end && end - start != 1)
        {
            Console.Write($"{start}-{end} ");
        }
        else if (start != end)
        {
            Console.Write($"{start} {end} ");
        }
        else
        {
            Console.Write($"{start} ");
        }
    }
}


// 6
// 180 141 174 143 142 175
