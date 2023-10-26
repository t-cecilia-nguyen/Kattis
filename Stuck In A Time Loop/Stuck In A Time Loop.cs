using System;

internal class Program {
    static void Main(string[] args) {
        int a = Int32.Parse(Console.ReadLine());        
        for (int i = 0; i < a; i++) {
            Console.WriteLine((i + 1) + " Abracadabra");
        }
    }
}
