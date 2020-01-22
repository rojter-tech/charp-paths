using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name){
            this.name = name;
            grades = new List<double>();
            count = 0;
            gradeSum = 0;
            highGrade = double.MinValue;
            lowGrade = double.MaxValue;
        }


        public void AddGrade(double grade){
            grades.Add(grade);
            gradeSum+=grade;
            count = grades.Count;
            if (highGrade < grade){highGrade = grade;}
            if (lowGrade > grade){lowGrade = grade;}
        }


        public Statistics GetStatistics(){
            var result = new Statistics();
            result.Average = gradeSum/count;
            result.High = highGrade;
            result.Low = lowGrade;
            result.Count = count;
            return result;
        }


        /*
        private double get_grade_sum(){
            double sum = 0.0;
            foreach (var digit in grades) {sum+=digit;}
            return sum;
        }
        

        private string get_name(){
            return name;
        }


        private double get_average_grade(){
            return gradeSum/count;
        }


        private double get_high_grade(){
            return highGrade;
        }


        private double get_low_grade(){
            return lowGrade;
        }


        private int get_grades_count(){
            return count;
        }


        private double get_grade_sum(){
            return gradeSum;
        }


        */


        // Fields
        private List<double> grades;
        private string name;
        private int count;
        private double gradeSum;
        private double highGrade;
        private double lowGrade;

    }
}