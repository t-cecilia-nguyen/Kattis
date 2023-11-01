using System;

internal class Program {
    static void Main(string[] args) {
        double costOfSeed = Double.Parse(Console.ReadLine());
        int numberOfLawns = Int32.Parse(Console.ReadLine());
        int counter = 0;
        double total = 0;
        while ( counter < numberOfLawns )
        {
            string input = Console.ReadLine();
            string[] inputs = input.Split(' ');
            if (double.TryParse(inputs[0], out double width) 
                && double.TryParse(inputs[1], out double height)) 
            {
                double area = width * height;
                total += area;
            }
            counter++;                        
        }
        total *= costOfSeed;
        Console.WriteLine(total);
    }
}
