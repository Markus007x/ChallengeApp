using ChallengeApp;

Console.WriteLine("Welcome to the employee's evluation programme ");
Console.WriteLine("Press q to exit");
Console.WriteLine("=============================================\n");


var employee = new Employee();

while (true)
{
    Console.WriteLine("Give next employee's rating: ");
    
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Avg Letter:{statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



