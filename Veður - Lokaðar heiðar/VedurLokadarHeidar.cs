using System;

internal class Program
{
    static void Main(string[] args)
    {
        int currentSpeed = Int32.Parse(Console.ReadLine());
        int roads = Int32.Parse(Console.ReadLine());

        // Each road with speed in single array element
        string[] roadAndSpeed = new string[roads];
        for (int i = 0; i < roads; i++)
        {
            roadAndSpeed[i] = Console.ReadLine();
        }

        // Spltting the element into separate speed values
        for (int i = 0; i < roadAndSpeed.Length; i++)
        {
            string[] roadSpeedSplit = roadAndSpeed[i].Split(' ');
            if (int.TryParse(roadSpeedSplit[1], out int safeSpeed))
            {
                if (currentSpeed <= safeSpeed)
                {
                    Console.WriteLine(roadSpeedSplit[0] + " opin");
                }
                else
                {
                    Console.WriteLine(roadSpeedSplit[0] + " lokud");
                }
            }
        }
    }
}
