using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int[] numbers = new int[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            if (int.TryParse(inputs[i], out int result))
            {
                numbers[i] = result;
            }
        }
        int[] lengths = new int[numbers[0]];
        for (int i = 0; i < numbers[0]; i++)
        {
            lengths[i] = Int32.Parse(Console.ReadLine());
        }

        double hypotenuse = Math.Sqrt(numbers[1] * numbers[1] + numbers[2] * numbers[2]);

        for (int i = 0; i < lengths.Length; i++)
        {
            if (lengths[i] <= hypotenuse)
            {
                Console.WriteLine("DA");
            } else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
