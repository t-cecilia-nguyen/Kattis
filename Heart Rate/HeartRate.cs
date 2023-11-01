using System;

internal class Program
{
    static void Main(string[] args)
    {
        int readings = int.Parse(Console.ReadLine());
        while (readings > 0)
        {
            string[] bp = Console.ReadLine().Split(' ');
            double b = double.Parse(bp[0]);
            double p = double.Parse(bp[1]);
            double answer = 60 * b / p;
            double diff = 60 / p;
            Console.WriteLine($"{answer - diff:f4} {answer:f4} {answer + diff:f4}");
            readings--;
        }      
    }
}
