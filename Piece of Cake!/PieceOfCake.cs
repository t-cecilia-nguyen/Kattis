using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sideSquare = numbers[0];        
        int h = sideSquare - numbers[1] > numbers[1] ? sideSquare - numbers[1] : numbers[1];
        int v = sideSquare - numbers[2] > numbers[2] ? sideSquare - numbers[2] : numbers[2];
        Console.WriteLine(v * h * 4);
    }
}
