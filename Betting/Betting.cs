using System;

internal class Program {
    static void Main(string[] args) {
        double option1 = Double.Parse(Console.ReadLine());
        Console.WriteLine(100 / option1);
        Console.WriteLine(100 / (100-option1));
    }
}
