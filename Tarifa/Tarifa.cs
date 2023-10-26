using System;

internal class Program {
    static void Main(string[] args) {
        int mbPerMonth = Int32.Parse(Console.ReadLine());
        int numberofMonths = Int32.Parse(Console.ReadLine());
        int totalMinutes = 0;
        for (int i = 0; i < numberofMonths; i++) {
            int minutes = Int32.Parse(Console.ReadLine());
            totalMinutes += mbPerMonth - minutes;
        }
        Console.WriteLine(totalMinutes + mbPerMonth);
    }
}
