using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        
        if (int.TryParse(inputs[0], out int result) && int.TryParse(inputs[1], out int result2)) {
            int answer = result + result2;
            Console.WriteLine(answer);
        }
    }
}
