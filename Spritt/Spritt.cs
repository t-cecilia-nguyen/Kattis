using System;

internal class Program {
    static void Main(string[] args) {
        string input = Console.ReadLine();
        string[] inputs = input.Split(' ');
        int sum = 0;
        if (int.TryParse(inputs[0], out int classrooms) && int.TryParse(inputs[1], out int totalBottles)) {
            for (int i = 0; i < classrooms; i++) {
                int bottles = Int32.Parse(Console.ReadLine());
                sum += bottles;
            }
            
            if(sum <= totalBottles) {
                Console.WriteLine("Jebb");
            } else {
                Console.WriteLine("Neibb");
            }
        }
    }
}
