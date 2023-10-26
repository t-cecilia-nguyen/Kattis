using System;

internal class Program {
    static void Main(string[] args) {
        int a = Int32.Parse(Console.ReadLine());        
        if (a % 2 == 0) {
            Console.WriteLine("Bob");
        } else {
            Console.WriteLine("Alice");
        }
    }
}
