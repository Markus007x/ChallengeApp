using System.IO;
using System.Text;

namespace ChallengeApp                                          // it store all values in file
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>();

        private const string fileName = "grades.txt";       
        public override event GradeAddedDelegate GradeAdded;

        

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);                 // writer writes the grade into fileName 
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());                  // this means = we
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(decimal grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);                 // writer writes the grade into fileName 
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);                 // writer writes the grade into fileName 
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);                 // writer writes the grade into fileName 
            }
        }

        //public override void AddGrade(string grade)
        //{
        //    using (var writer = File.AppendText(fileName))
        //    {
        //        writer.WriteLine(grade);                 // writer writes the grade into fileName 
        //    }
        //}

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                grade = grade.ToUpper();

                switch (grade)
                {
                    case "A":
                        this.AddGrade(100);
                        break;
                    case "B":
                        this.AddGrade(80);
                        break;
                    case "C":
                        this.AddGrade(60);
                        break;
                    case "D":
                        this.AddGrade(40);
                        break;
                    case "E":
                        this.AddGrade(20);
                        break;
                    case "F":
                        this.AddGrade(0);
                        break;
                    default:
                        throw new Exception("Invalid score value, only A-E");
                }
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
                    throw new Exception("Invalid score value, only A-E");
            }

        }

       

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }


        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        public Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }


    }


}




