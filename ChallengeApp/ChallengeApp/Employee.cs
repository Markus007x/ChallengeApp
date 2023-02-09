namespace ChallengeApp
{
    public class Employee
    {
        
        private List<int> score = new List<int>();

        public Employee(string surname, string name, int age)
        {
            this.surname = surname;
            this.name = name;
            this.age = age;
        }

        public string surname { get; private set; }
        public string name { get; private set; }
        public int age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
