using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] values = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };
        string input = Console.ReadLine().Replace("-", "");
        int total = 0;
        for (int i = 0; i < input.Length; i++)
        {
            total += int.Parse(input[i].ToString()) * values[i];
        }
        Console.WriteLine(total % 11 == 0 ? "1" : "0");
    }
}
