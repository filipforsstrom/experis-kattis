using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Program
{
    public static void Main()
    {
        var words = new List<string>();

        words.Add("FfF8vV5tbgPeIV52GaAb5qlI59RjILhjyIpzTFFBmyQdgk7M3JB96iMw2ba7T5lCF5wTsCxE96rxj9jQdpe90GhaF3B2Rw3PTQcA");
        words.Add("5OkA2JOgq4AWKw8uo389QSHuxk9t24Dbzar3NJnuaDDBia7Uhzt73rpj25aWnzzRI9FgE9KGwf6MiBY2yA6GvcuPmypMl8bwRmQn");
        words.Add("MQG9cqsx1bonW91FkrbTIYZdAjMYRTlI3dwB0R4RbrcPQvBACzrtXAVdLYr5WAqnRfA6CZGyP7wCKGhliiOpwlU2w0eAVeFUpuUK");
        words.Add("iGs5nRhl6sMxhmCMFAKTc71aG4prrnBCkAaFv1YsWaX3Zsvhxe5HrcJTJzuO7xj61Qxxkp4dwJwwyLAw8yrZ0XnQ3pBQcPCOeZum");
        words.Add("5OkA2JOgq4AWKw8uo389QSHuxk9t24Dbzar3NJnuaDDBia7Uhzt73rpj25aWnzzRI9FgE9KGwf6MiBY2yA6GvcuPmypMl8bwRmQn");
        words.Add("5OkA2JOgq4AWKw8uo389QSHuxk9t24Dbzar3NJnuaDDBia7Uhzt73rpj25aWnzzRI9FgE9KGwf6MiBY2yA6GvcuPmypMl8bwRmQn");
        words.Add("5OkA2JOgq4AWKw8uo389QSHuxk9t24Dbzar3NJnuaDDBia7Uhzt73rpj25aWnzzRI9FgE9KGwf6MiBY2yA6GvcuPmypMl8bwRmQn");
        // string input;

        // do
        // {
        //     input = Console.ReadLine();

        //     if (!string.IsNullOrEmpty(input))
        //     {
        //         words.Add(input);
        //     }

        // } while (!string.IsNullOrEmpty(input));

        foreach (var word in words)
        {
            Console.WriteLine(NumberOfAnagrams(word));
        }

        // var word = "FfF8vV5tbgPeIV52GaAb5qlI59RjILhjyIpzTFFBmyQdgk7M3JB96iMw2ba7T5lCF5wTsCxE96rxj9jQdpe90GhaF3B2Rw3PTQcA";
        // Console.WriteLine(NumberOfAnagrams(word));
    }

    private static BigInteger NumberOfAnagrams(string input)
    {
        var charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        BigInteger totalLengthFactorial = Factorial(input.Length);
        double totalNotUniqueChars = charCount.Count(pair => pair.Value > 1);
        BigInteger val = (BigInteger)Math.Pow(2, totalNotUniqueChars);
        BigInteger anagramCount = totalLengthFactorial / val;

        return anagramCount;
    }

    private static BigInteger Factorial(BigInteger n)
    {
        if (n <= 1)
            return 1;

        return n * Factorial(n - 1);
    }
}