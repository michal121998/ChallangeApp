using ChallangeApp;


namespace ChellengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void CheckEmployeeStatisticsMin()
        {
            // arrange
            var employee = new Employee("Anna", "Bujak");
            employee.AddGrade(2);
            employee.AddGrade(3);
            employee.AddGrade(4);

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(4, statistics.Max);
            Assert.AreEqual(3, statistics.Average);
        }
    }
}