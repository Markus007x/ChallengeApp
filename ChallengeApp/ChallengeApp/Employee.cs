using System.Diagnostics;

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
            // int valueInInt = Math.Floor(grade);                     // float to int floor
            // int valueInInt = Math.Ceiling(grade); ;                 // float to int ceiling
            // int valueInInt = (int)grade;
            //  float f = valueInInt;                                   // int to float

            if(grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
            
        }
        

        public void AddGrade(long grade)                            // Method LONG
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);            
        }
        public void AddGrade(int grade)                            // Method INT
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }


        public void AddGrade(string grade)                            // our methode
        {
            if (float.TryParse(grade, out float result))              // check whether the float is parse? if yes, then addgrade 
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
           
        }
       

        public Statistics GetStatistics()
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
            statistics.Average = statistics.Average / this.grades.Count;    // here we caluclate our loops devided our sum
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;                        // To calculate the Math.Max, we need a lower grade
            statistics.Min = float.MaxValue;

            for (int grade = 0; grade < 10; grade++)  
            {
                statistics.Max = Math.Max(statistics.Max, grade);   // taking max from class Math
                statistics.Min = Math.Min(statistics.Min, grade);   // taking Min from class Min
                statistics.Average += grade;                        // means: average = average + grade
            }
            statistics.Average = statistics.Average / this.grades.Count;    // here we caluclate our loops devided our sum
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
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
            statistics.Average = statistics.Average / this.grades.Count;    // here we caluclate our loops devided our sum
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;                        
            statistics.Min = float.MaxValue;
            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            } while (index <= this.grades.Count);
            
            statistics.Average = statistics.Average / this.grades.Count;    
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;                        
            statistics.Min = float.MaxValue;
            var index = 0;

            while (index <= this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;

            } 

            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }








    }
}
