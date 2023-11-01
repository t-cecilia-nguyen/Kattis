using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        char target = 'e';
        string replacement = "ee";
        string result = "";

        foreach (char c in input)
        {
            if (c == target)
            {
                result += replacement;
            } else
            {
                result += c;
            }
        }        
        Console.WriteLine(result);
    }
}
