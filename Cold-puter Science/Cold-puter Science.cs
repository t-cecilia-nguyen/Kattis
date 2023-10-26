using System;

internal class Program
{
    static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine());
        string tempInput = Console.ReadLine();
        string[] values = tempInput.Split(' ');
        int counter = 0;

        // Parse values to int
        for (int i = 0; i < a; i++)
        {
            if (int.TryParse(values[i], out int parsedValue))
            {
                if (parsedValue < 0)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}
