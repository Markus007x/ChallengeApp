namespace ChallengeApp
{
    public interface IEmployee                                        //   Co robicz....
    {
        string Name { get;  }
        string Surname { get; }
      
        void Addgrade(float grade);
        void Addgrade(double grade);
        void Addgrade(int grade);
        void Addgrade(char grade);
        void Addgrade(string grade);
       


        Statistics GetStatistics();              // contains only definitions || public private is not here               
    }           
}
