using ChallangeApp;


namespace ChellengeApp.Test
{
    public class Tests
    { 
        [Test]
        public void CheckSumEmployee1Points()
        {
            // arrange
            var employee = new Employee("Anna", "Bujak", 20);
            employee.AddScore(4);
            employee.AddScore(1);
            employee.AddScore(-2);

            // act
            int result = employee.MaxResult;

            // assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void CheckSumEmployee2Points()
        {
            //arrange
            var employee = new Employee("Adam", "Nowak", 24);
            employee.AddScore(-3);
            employee.AddScore(6);
            employee.AddScore(1);

            //act
            int result = employee.MaxResult;

            //assert
            Assert.AreEqual(4, result);
        }

        [Test]
        public void CheckSumEmployee3Points()
        {
            //arrange
            var employee = new Employee("Angelika", "Gaj", 25);
            employee.AddScore(7);
            employee.AddScore(-7);
            employee.AddScore(7);

            //act
            int result = employee.MaxResult;

            //assert
            Assert.AreEqual(7, result);
        }
    }
}