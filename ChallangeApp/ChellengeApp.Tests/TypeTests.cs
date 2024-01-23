using ChallangeApp;

namespace ChellengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TESTVAR()
        {
            // arrange
            var employee = GetEmployee("Anna", "Bujak");

            // act

            // assert
            Assert.AreNotEqual(employee, employee);

        }

        private Employee GetEmployee(string name, string surname) 
        {
            return new Employee(name, surname);
        }

        [Test]
        public void TestInt()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void TestString() 
        {
            string s1 = "NameAndSurname";
            string s2 = "NameAndSurname";

            Assert.AreEqual(s1, s2);
        }
    }
}
