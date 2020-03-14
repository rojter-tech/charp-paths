using System;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("data/events.txt");
            foreach (var line in lines)
            {
                string[] linepieces = line.Split(",");
                Tuple<string, string, int, int, int, int> thisevent = 
                    new Tuple <string, string, int, int, int, int>(
                        linepieces[0],
                        linepieces[1],
                        int.Parse(linepieces[2]),
                        int.Parse(linepieces[3]),
                        int.Parse(linepieces[4]),
                        int.Parse(linepieces[5])
                    );
                Console.WriteLine(thisevent);
            }
            
        }
    }
}
