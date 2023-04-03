
namespace ChallengeApp                                       // it store all values in memory
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;


        private List<float> grades = new List<float>();                   // New Private List for counting employees


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
            throw new NotImplementedException();
        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            if (GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());                  // this means = we
            }
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "-6" or "6-":
                    this.grades.Add(95);
                    break;
                case "5+" or "+5":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "-5" or "5-":
                    this.grades.Add(75);
                    break;
                case "+4" or "4+":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "-4" or "4-":
                    this.grades.Add(55);
                    break;
                case "3+" or "+3":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3" or "3-":
                    this.grades.Add(35);
                    break;
                case "+2" or "2+":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "-2" or "2-":
                    this.grades.Add(15);
                    break;
                case "+1" or "1+":
                    this.grades.Add(5);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    throw new Exception("Invalid grade Value");
            }

           
        }

        public override void AddGrade(char grade)
        {
            throw new Exception("Invalid grade Value");
        }
        public override void AddGrade(decimal grade)
        {
            decimal gradeAsFloat = (decimal)grade;
            this.AddGrade((float)gradeAsFloat);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;                        // To calculate the Math.Max, we need a lower grade
            statistics.Min = float.MaxValue;


            foreach (var grade in this.grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);   // taking max from class Math
                statistics.Min = Math.Min(statistics.Min, grade);   // taking Min from class Min
                statistics.Average += grade;                        // means: average = average + grade

            }
            statistics.Average /= this.grades.Count;    // here we caluclate our loops devided our sum

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }

            return statistics;
        }
    }
    }


