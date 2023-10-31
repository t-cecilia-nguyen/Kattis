using System;
using System.Collections.Generic;

internal class Program {
    static void Main(string[] args) {
        int[] probability = { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 };

        int hotels = Int32.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        HashSet<int> spaces = new HashSet<int>(Array.ConvertAll(input, int.Parse));
        int chance = 0;
        foreach (int i in spaces)
        {
            chance += probability[i - 2];
        }
        Console.WriteLine((double)chance / 36);
    }
}
