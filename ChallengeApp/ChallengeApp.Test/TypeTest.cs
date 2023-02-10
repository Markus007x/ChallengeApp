

namespace ChallengeApp.Test
{
    public class TypeTest
    {
        [Test]
        public void sumNumbers()
        {
            // arrange  Preparation
            int number1 = 4;
            int number2 = 7;

            // act      Execution
            int result = number1 + number2;

            // assert   Assumption whether successful
            Assert.AreEqual(11, result);
        }

        [Test]
        public void compareName()
        {
            // arrange  Preparation
            var employe1 = GetEmployee("Adam");
            var employe2 = GetEmployee("Monika");

            // act      Execution


            // assert   Assumption whether successful
            Assert.AreNotEqual(employe1, employe2);

        }
        private Employee GetEmployee(string surname)
        {
            return new Employee(surname);
        }
        [Test]
        public void compareFLOAT()
        {
            // arrange  Preparation
            var x1 = 11.548;
            var x2 = 12.624;

            // act      Execution

            // assert   Assumption whether successful
            Assert.AreNotEqual(x1, x2);

        }
        [Test]
        public void compareString()
        {
            // arrange  Preparation
            string name1 = "Adam";
            string name2 = "Monika";

            // act      Execution

            // assert   Assumption whether successful
            Assert.AreNotEqual(name1, name2);

        }
    }
}
