using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int atBats = int.Parse(Console.ReadLine());
        int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int sum = 0;
        int count = 0;
        for (int i = 0; i < inputs.Length; i++)
        {
            if (inputs[i] != -1)
            {
                sum += inputs[i];
                count++;
            }
        }
        Console.WriteLine((double)sum / count);
    }
}
