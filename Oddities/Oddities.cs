using System;

internal class Program {
    static void Main(string[] args) {
        int testCases = Int32.Parse(Console.ReadLine());
        int[] integers = new int[testCases];
        
        for (int i = 0; i < testCases; i++)
        {
            integers[i] = Int32.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < integers.Length; i++)
        {            
            if (integers[i] % 2 == 0)
            {
                Console.WriteLine(integers[i] + " is even");
            } else
            {
                Console.WriteLine(integers[i] + " is odd");
            }            
        }
    }
}
