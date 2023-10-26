using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        char[] charsInput = input.ToCharArray();           
        if(charsInput.Length > 1)
        {
            Console.Write(charsInput[0]);
            for (int i = 1; i < charsInput.Length - 1; i++)
            {
                if (charsInput[i] != charsInput[i - 1])
                {
                    Console.Write(charsInput[i]);
                }
            }                        
            if (charsInput[charsInput.Length - 1] != charsInput[charsInput.Length - 2])
            {
                Console.Write(charsInput[charsInput.Length - 1]);
            }                             
        } else
        {
            Console.Write(input);
        }
    }
}
