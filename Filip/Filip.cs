using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] inputReverse = new int[2];
        for (int i = 0; i < input.Length; i++)
        {
            char[] charInput = input[i].ToCharArray();
            Array.Reverse(charInput);
            string reversedInput = new string(charInput);
            inputReverse[i] = int.Parse(reversedInput);
        }
        
        if (inputReverse[0] > inputReverse[1])
        {
            Console.WriteLine(inputReverse[0]);
        } 
        else
        {
            Console.WriteLine(inputReverse[1]);
        }
    }
}
