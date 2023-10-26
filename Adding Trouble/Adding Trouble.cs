using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int[] parsedInputs = new int[3];
        for (int i = 0; i < 3; i++) {
            if(int.TryParse(inputs[i], out int result)) {
                parsedInputs[i] = result;
            }    
        }        
        if (parsedInputs[0] + parsedInputs[1] == parsedInputs[2]) {
            Console.WriteLine("correct!");
        } else {
            Console.WriteLine("wrong!");
        }
    }
}
