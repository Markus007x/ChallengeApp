namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        public string Name => "Adam";

        public string Surname => "Kowalski";

        public Statistics Addgrade(float grade)
        {
            return new Statistics();
        }
        public Statistics Addgrade(double grade)
        {
            return new Statistics();
        }
        public Statistics Addgrade(decimal grade)
        {
            return new Statistics();
        }
        public Statistics Addgrade(int grade)
        {
            return new Statistics();
        }
        public void Addgrade(char grade)
        {
            throw new NotImplementedException();
        }
        public void Addgrade(string grade)
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

        void IEmployee.Addgrade(float grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.Addgrade(double grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.Addgrade(int grade)
        {
            throw new NotImplementedException();
        }
       
    }
}
