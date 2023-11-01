using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int x = Int32.Parse(input[0]);
        int y = Int32.Parse(input[1]);
        int number = Int32.Parse(input[2]);

        for (int i = 0; i < number; i++)
        {
            if ( (i+1) % x == 0 && (i+1) % y == 0 )
            {
                Console.WriteLine("FizzBuzz");
            } else if ( (i+1) % x == 0)
            {
                Console.WriteLine("Fizz");
            } else if ( (i+1) % y == 0)
            {
                Console.WriteLine("Buzz");
            } else
            {
                Console.WriteLine(i + 1);
            }
        }
    }
}
