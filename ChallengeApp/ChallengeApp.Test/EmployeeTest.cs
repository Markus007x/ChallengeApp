

namespace ChallengeApp.Test
{
    public class Tests
    {
       [Test]
        public void CheckSumOperation()
        {
            // arrange  Preparation
            var employe1 = new Employee("Adam","Kowalski",35);
            employe1.AddScore(-5);
            employe1.AddScore(-10);

            // act      Execution
            var result = employe1.Result;

            
            // assert   Assumption whether successful
            Assert.AreEqual(-15, result);    
        }

    }
}