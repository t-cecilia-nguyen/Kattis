using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
        string input = Console.ReadLine().ToLower();
        int vowelCount = input.Count(c => vowels.Contains(c));                
        Console.WriteLine(vowelCount);
    }
}
