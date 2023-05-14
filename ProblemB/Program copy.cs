// using System;
// using System.Collections.Generic;
// using System.Linq;

// public class Program
// {
//     public static void Main()
//     {
//         string numberOfBuses = Console.ReadLine();
//         int n = int.Parse(numberOfBuses);

//         string buses = Console.ReadLine();
//         int[] numbers = buses.Split(' ').Select(int.Parse).ToArray();

//         Array.Sort(numbers);

//         FindConsecutiveValues(numbers);
//     }

//     public static void FindConsecutiveValues(int[] buses)
//     {
//         int start = buses[0];
//         int end = buses[0];

//         for (int i = 2; i < buses.Length; i++)
//         {
//             if (buses[i] - buses[i - 1] == 1 && buses[i] - buses[i - 2] == 2)
//             {
//                 // Three consecutive elements
//                 end = buses[i];
//             }
//             else
//             {

//                 if (start != end)
//                 {
//                     Console.Write($"{start}-{end} ");
//                 }
//                 else
//                 {
//                     Console.Write($"{start} ");
//                 }

//                 // Start a new consecutive range
//                 start = buses[i];
//                 end = buses[i];
//             }
//         }
//     }
// }


// // 6
// // 180 141 174 143 142 175
