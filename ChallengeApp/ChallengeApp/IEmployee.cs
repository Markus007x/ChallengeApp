using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee                                        //   Co robicz....
    {
        string Name { get;  }
        string Surname { get; }
      
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;

        Statistics GetStatistics();              // contains only definitions || public private is not here               
    }           
}
