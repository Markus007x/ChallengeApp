using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee : Person
    {
        //  private const char sex = 'M';                                    // this.sex = 'K' -> only in readonly in constructur string

        private List<float> grades = new List<float>();                   // New Private List for counting employees

        public Employee(string name, string surname, char sex)                 // constructor typing different people 
            : base(name,surname,sex)                                            // variable 'name' will be given to class Perosn and 'this.Name = name'
        {
                           
        }
      
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
                throw new Exception("Invalid grade value");
            }
            
        }
        

        public void AddGrade(long grade)                            // Method long
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);            
        }
        public void AddGrade(int grade)                            // Method int
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(char grade)                            // Method char
        {
            switch(grade)
            {
                case 'A':
                case 'a':    
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
                    
            }


        }

        public void AddGrade(string grade)                            // our methode
        {
           
            {

                if (float.TryParse(grade, out float result))              // check whether the float is parse? if yes, then addgrade 
                {
                    this.AddGrade(result);
                }
                else if (char.TryParse(grade, out char resultLetter))
                {
                    this.AddGrade(resultLetter);
                }

                else
                {
                    throw new Exception("String is not float");
                }
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
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);   // taking max from class Math
                    statistics.Min = Math.Min(statistics.Min, grade);   // taking Min from class Min
                    statistics.Average += grade;                        // means: average = average + grade
                }
              
            }
            statistics.Average /= this.grades.Count;    // here we caluclate our loops devided our sum

            switch(statistics.Average)
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
