using System;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int index = input.IndexOf("ss");
        Console.WriteLine(index >= 0 ? "hiss" : "no hiss");
    }
}
