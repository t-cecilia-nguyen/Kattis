using System;

internal class Program {
    static void Main(string[] args) {
        int echoes = Int32.Parse(Console.ReadLine());
        string[] inputs = new string[echoes];
        for (int i = 0; i < echoes; i++)
        {
            string input = Console.ReadLine();
            inputs[i] = input;
        }

        for (int i = 0; i < echoes; i++)
        {
            if ((i+1) % 2 != 0)
            {
                Console.WriteLine(inputs[i]);
            }
        }
    }
}
