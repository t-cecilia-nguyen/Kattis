using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        char[] charInput = input.ToCharArray();
        int index = 1;
        
        for (int i = 0; i < input.Length; i++)
        {
            if (charInput[i] == 'A')
            {
                if (index == 1)
                {
                    index += 1;
                } 
                else if (index == 2)
                {
                    index -= 1;
                }                 
            } 
            else if (charInput[i] == 'B')
            {
                if (index == 2)
                {
                    index += 1;
                } 
                else if (index == 3)
                {
                    index -= 1;
                }
            }
            else if (charInput[i] == 'C')
            {
                if (index == 1)
                {
                    index += 2;
                }                
                else if (index == 3)
                {
                    index -= 2;
                }                
            }
        }
        Console.WriteLine(index);
    }
}
