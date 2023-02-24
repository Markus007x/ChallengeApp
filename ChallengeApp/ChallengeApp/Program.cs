using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade("Adam");
employee.AddGrade(9f);
employee.AddGrade(2);
employee.AddGrade(7);
var statistics = employee.GetStatistics();

var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine($"Average: {statistics.Average:N2}");        // if we have dynamic strings, which changed, we use "$" in front of our writeline
Console.WriteLine($"Min: {statistics.Min}");                 // now the programe knows, that the interpolation is active
Console.WriteLine($"Max: {statistics.Max}");                // without that we would write ("Min: " + statistics.Min)
                                                            // using :N2 we show only 2 types ater comma