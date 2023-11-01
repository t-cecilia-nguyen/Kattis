using System;

internal class Program {
    static void Main(string[] args) {
        int numberOfRods = Int32.Parse(Console.ReadLine());
        int totalLength = 0;
        for (int i = 0; i < numberOfRods; i++)
        {
            int rod = Int32.Parse(Console.ReadLine());
            totalLength += rod;
        }

        totalLength = totalLength - numberOfRods + 1;

        Console.WriteLine(totalLength);
    }
}
