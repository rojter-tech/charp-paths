using System;
using System.Collections.Generic;

namespace Battlefield
{
    class Program
    {
        static void Main(string[] args)
        {
            int n_students = HandleNumberOfStudentsInput();
            
            if (n_students > 0)
            {
                Console.WriteLine("Okey, cool. You wish to register " + n_students + " students.\n");
                var students = new List<Student>();
                StoreStudents(students, n_students);

                System.Console.WriteLine("The students score are: \n");
                LoopStudents(students);
            }
            else
            {
                Console.WriteLine("You must type in an integer value that is bigger than zero.");
            }

        }

        static int HandleNumberOfStudentsInput()
        {
            Console.WriteLine("Type in the number of students:");
            string n_students = Console.ReadLine();
            bool is_integer = CheckIfInteger(n_students);
            if (is_integer)
            {
                return int.Parse(n_students);
            }
            else
            {
                return 0;
            }
        }

        static bool CheckIfInteger(string number)
        {
            bool isNumeric = int.TryParse(number, out int justSomeInt);
            return isNumeric;
        }

        static void StoreStudents(List<Student> students, int n_students)
        {
            for(int i = 0; i < n_students; i++)
            {
                students.Add(RandomStudentType());
            }
        }

        static readonly Random getrandom = new Random();

        static Student RandomStudentType()
        {
            List<Student> studend_types = new List<Student>(){
                new EsStudent(), new ItStudent(), new TeStudent()
            };
            int min = 0;  int max = studend_types.Count;
            {
                int random_index =  getrandom.Next(min, max);
                return studend_types[random_index];
            }
        }

        static String FixScoreSpace(int score)
        {
            if (score >= 10)
            {
                String score_spaces = new String(' ', 1);
                return score_spaces;
            }
            else
            {
                String score_spaces = new String(' ', 2);
                return score_spaces;
            }
        }

        static void LoopStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                /* Fix table output */
                // Spaces before score 
                string student_name = student.GetStudentName();
                int name_length = student_name.Length;
                String score_spaces = new String(' ', 20 - name_length);
                // Spaces after math score
                int math_score = student.GetMathematicsScore();
                string math_spaces = FixScoreSpace(math_score);
                // Spaces after swe score
                int swe_score = student.GetSwedishScore();
                string swe_spaces = FixScoreSpace(swe_score);
                // Spaces after eng score
                int eng_score = student.GetEnglishScore();
                string eng_spaces = FixScoreSpace(eng_score);
                
                Console.WriteLine(
                    student_name + ":" + score_spaces +
                    " Math: " + math_spaces + math_score + " |" +
                    " Swe: "  + swe_spaces  + swe_score  + " |" +
                    " Eng: "  + eng_spaces  + eng_score  + " | " + 
                    "(" + student.GetStudentProgram() + ")"
                    );
            }
        }
    }
}
