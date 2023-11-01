using System;

internal class Program {
    static void Main(string[] args) {
        int cases = Int32.Parse(Console.ReadLine());
        string[] rec = new string[cases];
        for (int i = 0; i < cases; i++)
        {
            rec[i] = Console.ReadLine();
        }
        for (int i = 0; i < rec.Length; i++)
        {
            string[] recSep = rec[i].Split(' ');            
            int r = Int32.Parse(recSep[0]);
            int e = Int32.Parse(recSep[1]);
            int c = Int32.Parse(recSep[2]);
            
            if ( e - c > r )
            {
                Console.WriteLine("advertise");
            } else if ( e - c < r )
            {
                Console.WriteLine("do not advertise");
            } else
            {
                Console.WriteLine("does not matter");
            }
        }
    }
}
