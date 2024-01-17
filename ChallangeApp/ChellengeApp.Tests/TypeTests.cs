using ChallangeApp;

namespace ChellengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TESTVAR()
        {
            // arrange
            var employee1 = GetEmployee("Anna", "Bujak", 20);
            var employee2 = GetEmployee("Adam", "Zak", 22);

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);

        }

        private Employee GetEmployee(string name, string surname, int age) 
        {
            return new Employee(name, surname, age);
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
