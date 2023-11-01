using System;
using System.Linq;


internal class Program
{
    static void Main(string[] args)
    {
        int sets = int.Parse(Console.ReadLine());
        while (sets > 0)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int setNumber = input[0];
            int days = input[1];
            int candles = 0;
            for (int i = 1; i <= days; i++)
            {
                candles += i + 1;
            }
            Console.WriteLine(setNumber + " " + candles);
            sets--;
        }
    }
}
