namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();           // New Private List for counting employees

        public Employee(string name, string surname)                 // constructor typing different people 
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }                     // setting the name into private

        public string Surname { get; private set; }                  // setting the surname into private

        public void AddGrade(float grade)                            // our methode
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;                        // To caluclkate the Math.Max, we need a lower grade
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);   // taking max from class Math
                statistics.Min = Math.Min(statistics.Min, grade);   // taking Min from class Min
                statistics.Average += grade;                        // means: average = average + grade
                
            }

            statistics.Average = statistics.Average / this.grades.Count;    // here we caluclate our loops devided our sum

            return statistics;
        }
    }
}
