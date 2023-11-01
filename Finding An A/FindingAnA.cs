using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        int indexofA = input.IndexOf('a');
        
        for (int i = indexofA; i < input.Length; i++) {
            Console.Write(input[i]);
        }
    }
}
