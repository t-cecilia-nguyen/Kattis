using System;

internal class Program {
    static void Main(string[] args) {
        double input = Double.Parse(Console.ReadLine());
        double output = Math.Round(input / 4, 2);
        Console.WriteLine(output);
    }
}
