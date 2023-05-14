using System;

public class Program
{
    public static void Main()
    {
        string name;
        while ((name = Console.ReadLine()) != null)
        {
            string compactName = CompactName(name);
            Console.WriteLine(compactName);
        }
    }

    static string CompactName(string name)
    {
        string compactName = string.Empty;
        char previousChar = '\0';

        foreach (char c in name)
        {
            if (c != previousChar)
            {
                compactName += c;
                previousChar = c;
            }
        }

        return compactName;
    }
}