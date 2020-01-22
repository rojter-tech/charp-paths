using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("rOjter's Grade Book");
            book.AddGrade(89.12);
            book.AddGrade(21.54);
            book.AddGrade(32.63);
            book.AddGrade(99.81);

            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The highest grade is {stats.High:N1}.");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}.");
            Console.WriteLine($"Number of grades recorded is {stats.Count}.");
            
        }
    }
}
