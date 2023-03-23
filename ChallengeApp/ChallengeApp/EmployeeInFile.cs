namespace ChallengeApp                                          // it store all values in file
{
    public class EmployeeInFile : EmployeeBase
    {

        
        public const string fileName = "C:\\Users\\ersch\\OneDrive\\Desktop\\grades.txt";

        private List<float> grades = new List<float>();

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);                 // writer writes the grade into fileName 
            }
        }
        
        public override void AddGrade(decimal grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
                         
                                                 
        var result = new Statistics();

            if (File.Exists(fileName))                 // first control whether the file exist, because without we could get an error
            {                                           // if not exists, then give me back "Return" empty
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var numer = float.Parse(line);
                        result.Min = float.MinValue;                              // calculating MIN, MAX, Average etc.
                        result.Max = float.MaxValue;
                        result.Average = 0;

                        foreach (var grade in this.grades)
                        {
                            result.Min = Math.Min(result.Min, grade);
                            result.Max = Math.Max(result.Max, grade);
                            result.Average += grade;
                        }
                        result.Average /= this.grades.Count;
                    }

                }
                
            }
            return result;
        }
    }
}
