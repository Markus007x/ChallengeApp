

namespace ChallengeApp.Test
{
    public class EmployeeTest
    {
        [Test]
        public void CheckMaxGrade()
        {
            // arrange  Preparation
            var employee = new Employee("Adam", "Kowalski");
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
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade(7);

            // act      Execution
            var statistics = employee.GetStatistics();


            // assert   Assumption whether successful
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void CheckAverage()
        {
            // arrange  Preparation
            var employee = new Employee("Adam", "Kowalski");
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