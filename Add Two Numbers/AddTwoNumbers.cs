using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();

        string[] inputSplit = input.Split(' ');
        int sum = 0;
        for (int i = 0; i < inputSplit.Length; i++)
        {
            if (int.TryParse(inputSplit[i], out int result)) {
                sum += result;
            }
        }
        Console.WriteLine(sum);
    }
}
