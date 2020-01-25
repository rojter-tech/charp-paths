namespace Battlefield
{
    public class Student
    {
        public Student()
        {
            RandomStudentData random_studend_data = new RandomStudentData();
            name = random_studend_data.Name;
            mathematics = random_studend_data.Mathematics;
            swedish = random_studend_data.Swedish;
            english = random_studend_data.English;
        }

        public void SetStudentName(string name)
        {
            this.name = name;
        }

        public int GetStudentBonus()
        {
            return bonus;
        }

        public string GetStudentName()
        {
            return name;
        }

        public string GetStudentProgram()
        {
            return program;
        }

        public int GetMathematicsScore()
        {
            return mathematics;
        }

        public int GetSwedishScore()
        {
            return swedish;
        }

        public int GetEnglishScore()
        {
            return english;
        }


        protected string program;
        protected string name;
        protected int english;
        protected int mathematics;
        protected int swedish;
        protected int bonus;
        
    }
}
