using System;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Console.WriteLine(input == "OCT 31" || input == "DEC 25" ? "yup" : "nope");
    }
}
