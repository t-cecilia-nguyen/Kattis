using System;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char first = '(';
        char second = ')';

        int indexOfFirst = input.IndexOf(first);
        int indexOfSecond = input.IndexOf(second);

        int before = indexOfFirst;
        int after = input.Length - indexOfSecond - 1;

        Console.WriteLine(before != after ? "fix" : "correct");                  
    }
}
