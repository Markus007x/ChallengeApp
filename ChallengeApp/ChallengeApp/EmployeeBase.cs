
namespace ChallengeApp                              // include all methods which will be universal for all employees. 
{
    public abstract class EmployeeBase : IEmployee               
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract Statistics GetStatistics();
        
        public abstract void AddGrade(float grade);  // Implementatio is in EmployeeMemorey. Here we only use the method

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);
        public abstract void AddGrade(decimal grade);

        
    }
}
