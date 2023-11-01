using System;
using System.Linq;

internal class Program {
    static void Main(string[] args) {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(input[0] * (input[1] - 1) + 1);
    }
}
