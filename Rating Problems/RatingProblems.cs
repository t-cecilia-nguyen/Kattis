using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] inputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int judges = inputs[0];
        int judgesRated = inputs[1];
        int sum = 0;
        for (int i = 0; i < judgesRated; i++)
        {
            sum += int.Parse(Console.ReadLine());
        }
        double minimum = (((double)judges - judgesRated) * -3 + sum) / judges;
        double maximum = (((double)judges - judgesRated) * 3 + sum) / judges;
        Console.WriteLine(minimum + " " + maximum);
    }
}
