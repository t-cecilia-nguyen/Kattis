using System;

internal class Program {
    static void Main(string[] args) {
        int numberOfInts = Int32.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int sum = 0;
        for (int i = 0; i < numberOfInts; i++) {
            if (int.TryParse(inputs[i], out int result)) {
                sum += result;
            }
        }
        Console.WriteLine(sum);
    }
}
