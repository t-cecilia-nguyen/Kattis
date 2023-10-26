using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split('-');

        for (int i = 0; i < inputs.Length; i++)
        {
            Console.Write(inputs[i][0]);
        }
    }
}
