using System;

internal class Program {
    static void Main(string[] args) {
        int input = Int32.Parse(Console.ReadLine());
        if (input % 2 == 0) {
            Console.WriteLine("second");
        } else {
            Console.WriteLine("first");
        }
    }
}
