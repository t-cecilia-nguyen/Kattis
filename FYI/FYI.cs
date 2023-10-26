using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string prefix = "555";
        if (input.StartsWith(prefix))
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
