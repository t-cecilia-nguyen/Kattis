using System;

internal class Program
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int hours = Int32.Parse(inputs[0]);
        int minutes = Int32.Parse(inputs[1]);
        minutes -= 45;
        if (minutes < 0)
        {
            minutes += 60;
            hours -= 1;
        }
        if (hours < 0) 
        {
            hours = 23;
        }
        Console.WriteLine(hours + " " + minutes);
    }
}
