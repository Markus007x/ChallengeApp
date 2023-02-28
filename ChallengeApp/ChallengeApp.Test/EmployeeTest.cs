

namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckMaxGrade()
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(7);

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(7, statistics.Max);
        }
        [Test]
        public void CheckMinGrade()
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(7);

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(1, statistics.Min);
        }

        [Test]
        public void CheckAverageLetter()                    // Test rating with Letters
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade('c');
            employee.AddGrade('B');
            employee.AddGrade(3);

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void CheckAverage()
            
        {
            // arrange  Preparation
            var employee = new Employee();
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(7);

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
        
    }
}