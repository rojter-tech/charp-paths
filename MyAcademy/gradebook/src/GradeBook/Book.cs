using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book : NamedObject
    {
        // Pubic Fields
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public event GradeAddedDelegate GradeAdded;

        // Static Fields
        public const string CATEGORY = "Science";

        // Public Methods
        public Book(string name) : base(name)
        {
            Name = name;
            grades = new List<double>();
            count = 0;
            gradeSum = 0;
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;
                
                default:
                    AddGrade(0);
                    break;
            }
        }

        public void AddGrade(double grade){
            if(grade <= 100.0 && grade >= 0.0)
            {
                grades.Add(grade);
                gradeSum+=grade;
                count = grades.Count;
                if (highGrade < grade){highGrade = grade;}
                if (lowGrade > grade){lowGrade = grade;}

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Bad user input, invalid {nameof(grade)}");
            }
        }

        


        private Statistics zero_stats(Statistics stats)
        {
            stats.Average = 0.0;
            stats.High = 0.0;
            stats.Low = 0.0;
            stats.Count = 0;
            return stats;
        }

        public Statistics GetStatistics(){
            var result = new Statistics();
            if (count == 0){
                result = zero_stats(result);
            }
            else {
                result.Average = gradeSum/count;
                result.High = highGrade;
                result.Low = lowGrade;
                result.Count = count;
            }

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;
                
                case var d when d >= 70.0:
                    result.Letter = 'C';
                    break;
                
                case var d when d >= 60.0:
                    result.Letter = 'D';
                    break;
                
                default:
                    result.Letter = 'F';
                    break;
            }
            
            return result;
        }

        // Private Fields
        private List<double> grades;
        private int count;
        private double gradeSum;
        private double highGrade;
        private double lowGrade;

    }
}