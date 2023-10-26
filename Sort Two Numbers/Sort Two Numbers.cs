using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputSplit = input.Split(' ');
        int[] intArray = new int[inputSplit.Length];

        for (int i = 0; i < inputSplit.Length; i++) {
            if (int.TryParse(inputSplit[i], out int result)) {
                intArray[i] = result;
            }
        }

        if (intArray[0] < intArray[1]) {
            Console.WriteLine(intArray[0] + " " + intArray[1]);
        } else {
            Console.WriteLine(intArray[1] + " " + intArray[0]);
        }
    }
}
