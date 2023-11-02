using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int knots = int.Parse(Console.ReadLine());
        int[] knotsToLearn = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] knotsLearned = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        HashSet<int> set = new HashSet<int>(knotsLearned);
        for (int i = 0; i < knotsLearned.Length + 1; i++) // +1 to account for missing element
        {
            if (!set.Contains(knotsToLearn[i]))
            {
                Console.WriteLine(knotsToLearn[i]);
                break;
            }
        }
    }
}
