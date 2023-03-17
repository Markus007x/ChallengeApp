

using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckMaxGrade()
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade("1");
            employee.AddGrade("2");
            employee.AddGrade("3-");    // Solution -> 35

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(35, statistics.Max);
        }
        [Test]
        public void CheckMinGrade()
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade("1");
            employee.AddGrade("5");
            employee.AddGrade("6"); // solution -> 0

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(0, statistics.Min);
        }

        
        //public void CheckAverageLetter()                    // Test rating with Letters
        //{
        //    // arrange  Preparation
        //    var employee = new Employee();
        //    employee.AddGrade('c');
        //    employee.AddGrade('B');
        //    employee.AddGrade(3);

        //    // act      Execution
        //    var statistics = employee.GetStatistics();


        //    // assert   Assumption whether successful
        //    Assert.AreEqual('C', statistics.AverageLetter);
        //}

        [Test]
        public void CheckAverage()
            
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade("+2");
            employee.AddGrade("3-");
            employee.AddGrade("5");

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual((46.67), Math.Round(statistics.Average, 2));
        }
        
    }
}