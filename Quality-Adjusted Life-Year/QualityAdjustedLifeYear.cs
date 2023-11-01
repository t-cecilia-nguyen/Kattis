using System;

internal class Program {
    static void Main(string[] args) {
        double periods = Double.Parse(Console.ReadLine());
        double qaly = 0;        
        for (int i = 0; i < periods; i++)
        {
            string input = Console.ReadLine();
            string[] inputSplit = input.Split(' ');
            double totalResult = 1;
            for (int j = 0; j < inputSplit.Length; j++)
            {                           
                if (double.TryParse(inputSplit[j], out double result))
                {
                    totalResult *= result;
                    totalResult = Math.Round(totalResult, 2);
                }                
            }
            qaly += totalResult;
        }
        Console.WriteLine(qaly);
    }
}
