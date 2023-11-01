using System;

internal class Program {
    static void Main(string[] args) {
        int testCases = Int32.Parse(Console.ReadLine());
        string[] pairs = new string[testCases * 2];
        for (int i = 0; i < pairs.Length; i += 2)
        {
            pairs[i] = Console.ReadLine();
            pairs[i + 1] = Console.ReadLine();
        }
        for (int i = 0; i < pairs.Length; i += 2)
        {
            char[] characters = pairs[i].ToCharArray();
            Array.ForEach(characters, c => Console.Write(c));
            Console.WriteLine();
            char[] characters2 = pairs[i+1].ToCharArray();
            Array.ForEach(characters2, c => Console.Write(c));
            Console.WriteLine();
            for (int j = 0; j < pairs[i].Length; j++)
            {
                if (pairs[i][j] == pairs[i + 1][j])
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine("\n");
        }        
    }
}
