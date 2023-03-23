using ChallengeApp;


    Console.WriteLine("Welcome to the employee's evluation programme ");
    Console.WriteLine("Rate between 1 - 6 with e.g. 2+ or -3");
    Console.WriteLine("Press q to exit");
    var employee = new EmployeeInFile("Adam", "Kowalski");
    employee.AddGrade(15651f);
    employee.AddGrade(54.15f);
    employee.AddGrade('D');
    employee.AddGrade(007f);

//while (true)
//{
//    Console.WriteLine($"GPress (S) for Supervisor or (E) for Employee: ");


//    var input = Console.ReadLine();
//    if (input.Length == 1)
//    {
//        if (input == "S")
//        {
//            Console.WriteLine("Hallo Supervisor");
//        }

//        if (input == "E")
//        {
//            Console.WriteLine("Hallo Employee");
//        }
//        else
//        {
//            break;
//        }
//    }
//}


Console.WriteLine("========================================================\n");


    

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


    //while (true)
    //{
    //    Console.WriteLine($"Give next rating: ");


    //    var input = Console.ReadLine();
    //    if (input.Length == 1)
    //    {
    //        if (input == "q")
    //        {
    //            break;
    //        }

    //    }
    //    try
    //    {
    //        employee.AddGrade(input);
    //    }
    //    catch (Exception e)
    //    {
    //        Console.WriteLine($"Exception catched: {e.Message}");
    //    }
    //}

    //var statistics = employee.GetStatistics();
    //Console.WriteLine($"AVG: {statistics.Average:N2}");
    //Console.WriteLine($"Avg Letter:{statistics.AverageLetter}");
    //Console.WriteLine($"Min: {statistics.Min}");
    //Console.WriteLine($"Max: {statistics.Max}");



