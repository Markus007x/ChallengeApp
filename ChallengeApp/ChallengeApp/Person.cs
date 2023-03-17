namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
          
        }

        public string Name { get;  }
        public string Surname { get; }
        
    }

}
