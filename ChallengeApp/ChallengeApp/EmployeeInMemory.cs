

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace ChallengeApp                                       // it store all values in memory
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();         // New Private List for counting employees

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());                  // this means = we
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }


        public override void AddGrade(decimal grade)
        {
            decimal gradeAsFloat = (decimal)grade;
            this.AddGrade((float)gradeAsFloat);
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String and not float");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A' or 'a':
                    this.AddGrade(100);
                    break;
                case 'B' or 'b':
                    this.AddGrade(80);
                    break;
                case 'C' or 'c':
                    this.AddGrade(60);
                    break;
                case 'D' or 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }

        }


        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }


            return statistics;
        }
    }
}


