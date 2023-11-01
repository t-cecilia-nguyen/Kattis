using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        int count = 3;
        string space = " ";
        string[] newInput = new String[count];
        for (int i = 0; i < count; i++) {
            newInput[i] = input;
        }
        string result = string.Join(space, newInput);
        Console.WriteLine(result);
    }
}
