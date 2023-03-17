
namespace ChallengeApp                                              //     Jak to zrobic.....
{
    public class Employee : IEmployee
    {   

        private List<float> grades = new List<float>();                   // New Private List for counting employees

        public Employee()
        {

        }

        public Employee(string name, string surname)                 // constructor typing different people 
                                                                       
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private  set; }                  // setting the surname into private
        public string Surname { get; private set; }                  // setting the surname into private

        public void Addgrade(decimal grade)
        {
            decimal gradeAsFloat = (decimal)grade;
            this.AddGrade((float)gradeAsFloat);
        }
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
        //public void AddGrade(int grade)                            // Method int
        //{
        //    float gradeAsFloat = (float)grade;
        //    this.AddGrade(gradeAsFloat);
        //}
        public void Addgrade(char grade)
        {
            throw new Exception("Invalid grade value");
            
        }

        public void AddGrade(string grade)                           // Method string
        {

            //if (float.TryParse(grade, out float result))              // check whether the float is parse? if yes, then addgrade 
            //{
            //    this.AddGrade(result);
            //}
            //else 

            //{
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
                    
            //}


        }

        //public void AddGrade(string grade)                            // our methode
        //{

        //    {

        //        if (float.TryParse(grade, out float result))              // check whether the float is parse? if yes, then addgrade 
        //        {
        //            this.AddGrade(result);
        //        }
        //        else if (char.TryParse(grade, out char resultLetter))
        //        {
        //            this.AddGrade(resultLetter);
        //        }

        //        else
        //        {
        //            throw new Exception("String is not float");
        //        }
        //    }


        //}

        public void Addgrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void Addgrade(string grade)
        {
            throw new NotImplementedException();
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
