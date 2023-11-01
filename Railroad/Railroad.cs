using System;
using System.Linq;

internal class Program {
    static void Main(string[] args) {
        int[] tracks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();        
        int y = tracks[1];
        Console.WriteLine(y % 2 == 0 ? "possible" : "impossible");
    }
}
