using System;

internal class Program
{
    static void Main(string[] args)
    {
        char[] number = { 'A', 'K', 'Q', 'J', 'T', '9', '8', '7' };
        int[] dominant = { 11, 4, 3, 20, 10, 14, 0, 0 };
        int[] nonDominant = { 11, 4, 3, 2, 10, 0, 0, 0 };

        string[] input = Console.ReadLine().Split(' ');        
        int hands = Int32.Parse(input[0]);
        char suit = input[1][0];        
        int score = 0;

        for (int i = 0; i < hands*4; i++)
        {
            string card = Console.ReadLine();
            int index = Array.IndexOf(number, card[0]);
            char cardSuit = card[1];
            if (cardSuit != suit)
            {
                score += nonDominant[index];
            } else
            {
                score += dominant[index];
            }            
        }
        Console.WriteLine(score);
    }
}
