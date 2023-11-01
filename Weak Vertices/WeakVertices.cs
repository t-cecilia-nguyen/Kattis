using System;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        while (n > 0)
        {            
            int[,] graph = new int[n,n]; // Create graph
            bool[] weak = new bool[n]; // Create list of weak vertices

            // Initialize array of weak vertices
            for ( int i = 0; i < n; i++ )
            {
                weak[i] = true;
            }

            for (int i = 0; i < n; i++) // read in graph
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    graph[i, j] = int.Parse(input[j]);
                }
            }
                
            // Determine wheather vertices are weak or not.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if ((graph[i, j] & graph[j, k] & graph[i, k]) != 0)
                        {
                            weak[i] = false;
                        }
                    }
                }
            }

            // Print all weak vertices
            for (int i = 0; i < n; i++)
            {
                if (weak[i])
                {
                    Console.Write(i + " ");
                }                
            }
            Console.WriteLine();
            n = int.Parse(Console.ReadLine()); // Continue loop
        }

    }
}
