namespace ChallangeApp
{
    public class Employee
    {
        private List<int> point = new List<int>();
        public Employee(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int maxResult
        {
            get
            {
                return this.point.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.point.Add(number);
        }
    }
}