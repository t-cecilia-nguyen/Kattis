using System;

internal class Program {
    static void Main(string[] args) {
        int testCases = Int32.Parse(Console.ReadLine());
        int[] testCasesOutput = new int[testCases];
        for (int i = 0; i < testCases; i++)
        {
            int trips = Int32.Parse(Console.ReadLine());
            string[] cities = new string[trips];
            // City input
            for (int l = 0; l < cities.Length; l++)
            {
                cities[l] = Console.ReadLine();
            }
            // Pick all elements one by one
            int uniqueCities = 1;
            for (int j = 1; j < cities.Length; j++)
            {
                int k = 0;
                for (k = 0; k < j; k++)
                {
                    if (cities[j] == cities[k])
                    {
                        break;
                    }
                }
                if (j == k)
                {
                    uniqueCities++;
                }
            }
            testCasesOutput[i] = uniqueCities;
            uniqueCities = 0;
        }
        for (int c = 0; c < testCasesOutput.Length; c++)
        {
            Console.WriteLine(testCasesOutput[c]);
        }
    }
}
