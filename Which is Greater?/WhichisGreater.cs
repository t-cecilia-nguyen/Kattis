using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        if (int.TryParse(inputs[0], out int first) && int.TryParse(inputs[1], out int second)) {
            if (first > second) {
                Console.WriteLine("1");
            } else {
                Console.WriteLine("0");
            }
        }
    }
}
