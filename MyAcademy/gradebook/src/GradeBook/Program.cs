using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("rOjter's Grade Book");
            string grade_input;
            double grade;
            while(true)
            {
                Console.WriteLine("Add a grade to the book or press 'q(Q)' to exit:");
                grade_input = Console.ReadLine();

                if(grade_input == "q" || grade_input == "Q"){break;}

                try
                {
                    grade = double.Parse(grade_input);
                    book.AddGrade(grade);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Value can only be between 0 and 100");
                }

                
            }
            
            var stats = book.GetStatistics();

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average:N1}.");
            Console.WriteLine($"The highest grade is {stats.High:N1}.");
            Console.WriteLine($"The lowest grade is {stats.Low:N1}.");
            Console.WriteLine($"Number of grades recorded is {stats.Count}.");
            Console.WriteLine($"The letter grade is {stats.Letter}");
            
        }
    }
}
