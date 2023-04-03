using ChallengeApp;


    Console.WriteLine("Welcome to the employee's evluation programme ");
    Console.WriteLine("Rate between 1 - 6 with e.g. 2+ or -3");
    Console.WriteLine("Press q to exit");
    var employee = new EmployeeInMemory("Adam", "Kowalski");

    employee.GradeAdded += EmployeeGradeAdded;

    Console.WriteLine("========================================================\n");
void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Added grade");
}

while (true)
{
    Console.WriteLine($"Give next rating: ");
    var input = Console.ReadLine();
    if (input.Length == 1)
    {
        if (input == "q")
        {
            break;
        }

    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception error)
    {
        Console.WriteLine($"Exception catched: {error.Message}");
    }
}


    var statistics = employee.GetStatistics();
    Console.WriteLine($"AVG: {statistics.Average:N2}");
    Console.WriteLine($"Avg Letter:{statistics.AverageLetter}");
    Console.WriteLine($"Min: {statistics.Min}");
    Console.WriteLine($"Max: {statistics.Max}");




