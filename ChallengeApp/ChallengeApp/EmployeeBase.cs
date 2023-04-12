
namespace ChallengeApp                              // include all methods which will be universal for all employees. 
                                                    // short programme, its only implementing the methods addgrade
{
    public abstract class EmployeeBase : IEmployee               
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);  // our method delegate

        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        
        public string Name { get; private set; }
        public string Surname { get; private set; }

        
        public abstract void AddGrade(float grade);            // Implementation is in EmployeeMemorey. Here we only use the method
         
     
        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(char grade);
        public abstract void AddGrade(decimal grade);

        public abstract Statistics GetStatistics();
    }
}
