using ChallengeApp;

Employee employe1 = new Employee("Adam","Kowalski",35);
Employee employe2 = new Employee("Monika","Walesa",29);
Employee employe3 = new Employee("Zuzia","Morawiecki",48);

employe1.AddScore(1);   // 15 Points
employe1.AddScore(2);
employe1.AddScore(3);
employe1.AddScore(4);
employe1.AddScore(5);

employe2.AddScore(2);   // 20 Points
employe2.AddScore(3);
employe2.AddScore(4);
employe2.AddScore(5);
employe2.AddScore(6);

employe3.AddScore(1);   // 5 Points
employe3.AddScore(1);
employe3.AddScore(1);
employe3.AddScore(1);
employe3.AddScore(1);


List<Employee> employes = new List<Employee>()
{
    employe1, employe2, employe3
};

int maxResult = -1;
Employee employeWithMaxResult = null;

foreach (var employe in employes)
{
    if (employe.Result > maxResult )
    {
        maxResult= employe.Result;
        employeWithMaxResult = employe;
    }
}
Console.WriteLine("Employee with max. points \n ");
Console.WriteLine("Surename: " + employeWithMaxResult.surname );
Console.WriteLine("Name: " + employeWithMaxResult.name);
Console.WriteLine("Age: " + employeWithMaxResult.age);
Console.WriteLine("Result: " + employeWithMaxResult.Result + " Points");
