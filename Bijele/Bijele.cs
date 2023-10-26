using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] pieces = input.Split(' ');
        int[] correctPieces = { 1, 1, 2, 2, 2, 8 };
        int[] output = new int[pieces.Length];
        for (int i = 0; i < pieces.Length; i++)
        {
            if (int.TryParse(pieces[i], out int result)) {
            output[i] = correctPieces[i] - result;
        }
    }
    string finalResult = string.Join(" ", output);
    Console.WriteLine(finalResult);
    }
}
