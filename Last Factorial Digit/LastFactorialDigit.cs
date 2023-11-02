using System;

internal class Program
{
    static void Main(string[] args)
    {
        int testCases = int.Parse(Console.ReadLine());
        while (testCases > 0)
        {
            int integer = int.Parse(Console.ReadLine());
            int answer = 1;
            for (int i = 1; i <= integer; i++)
            {
                answer *= i;
            }
            while (answer > 10)
            {
                answer %= 10;
            }
            Console.WriteLine(answer);
            testCases--;
        }
    }
}
