namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Adam";

        public string Surname => "Kowalski";

        public Statistics AddGrade(float grade)
        {
            return new Statistics();
        }
        public Statistics AddGrade(double grade)
        {
            return new Statistics();
        }
        public Statistics AddGrade(decimal grade)
        {
            return new Statistics();
        }
        public Statistics AddGrade(int grade)
        {
            return new Statistics();
        }
        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }
        public void AddGrade(string grade)
        {
            throw new NotImplementedException();
            // 6 => 100
            // 5 => 80
            // 4 => 60
            // 3 => 40
            // -3 => 35
            // 3- => 35
            // 2+ => 25
            // +2 => 25
            // 2 => 20
            // 1 => 0
            // + / -
        }
        public Statistics GetStatistics()
        {
            return new Statistics();
        }

        void IEmployee.AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(int grade)
        {
            throw new NotImplementedException();
        }
       
    }
}
