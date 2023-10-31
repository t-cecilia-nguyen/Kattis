using System;
using System.Linq;

internal class Program {
    static void Main(string[] args) {
        string[] inputs = Console.ReadLine().Split(' ');
        int gross = Int32.Parse(inputs[0]);
        int truckWeight = Int32.Parse(inputs[1]);
        int numberOfItems = Int32.Parse(inputs[2]);
        
        int[] items = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(0.9 * (gross - truckWeight) - items.Sum());
    }
}
