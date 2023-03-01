using ChallengeApp;

Console.WriteLine("Welcome to the employee's evluation programme ");
Console.WriteLine("Rate between 0 -> 100 or from A to D. A is 100 and D 20");
Console.WriteLine("Press q to exit");
Console.WriteLine("========================================================\n");


var employee = new Employee("Adam", "Kowalski");

//try
//{
//    Employee emp = null;
//    var name = emp.Surname;
//}
//catch(Exception exception)
//{
//    Console.WriteLine(exception.Message);
//}
//finally
//{
//    Console.WriteLine("Finally here");
//}


while (true)
{
    Console.WriteLine("Give next employee's rating: ");

    
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
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }    
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average:N2}");
Console.WriteLine($"Avg Letter:{statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");



