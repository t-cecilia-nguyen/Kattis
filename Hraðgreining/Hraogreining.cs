using System;

internal class Program {
    static void Main(string[] args) {
        string pattern = "COV";
        string input = Console.ReadLine();
        int index = input.IndexOf(pattern);
        if (index >= 0) {
            Console.WriteLine("Veikur!");
        } else {
            Console.WriteLine("Ekki veikur!");
        }
        
    }
}
