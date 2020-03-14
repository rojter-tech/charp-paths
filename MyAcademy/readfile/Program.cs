using System;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Läs in events.txt filen rad för rad och lagra i en "lista med strängar" (string[])
            string[] lines = System.IO.File.ReadAllLines("data/events.txt");
            
            //Loopa igenom varje rad i events.txt
            foreach (var line in lines) // För varje line i lines gör bla bla
            {
                string[] linepieces = line.Split(","); // Separera alla delar som ligger intill kommatecken
                var thisevent = new Tuple<string, string, int, int, int, int>(
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
