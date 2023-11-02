using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] tri = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(tri[0] * tri[1] / 2.0);
    }
}
