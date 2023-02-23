using ChallengeApp;

var employee = new Employee("Adam", "Kowalski");
employee.AddGrade(1);
employee.AddGrade(2);
employee.AddGrade(7);
var statistics = employee.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2}");        // if we have dynamic strings, which changed, we use "$" in front of our writeline
Console.WriteLine($"Min: {statistics.Min}");                 // now the programe knows, that the interpolation is active
Console.WriteLine($"Max: {statistics.Max}");                // without that we would write ("Min: " + statistics.Min)
                                                            // using :N2 we show only 2 types ater comma