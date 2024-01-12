using ChallangeApp;

Employee employee1 = new Employee("Anna", "Bujak", 20);
Employee employee2 = new Employee("Adam", "Nowak", 24);
Employee employee3 = new Employee("Angelika", "Gaj", 25);

employee1.AddScore(3);
employee1.AddScore(6);
employee1.AddScore(1);

employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(3);

employee3.AddScore(6);
employee3.AddScore(4);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.maxResult > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.maxResult;
    }
}

Console.WriteLine("Najlepszy pracownik to: " + employeeWithMaxResult.Name + " " + 
    employeeWithMaxResult.LastName + " " + employeeWithMaxResult.Age +
    " lat" + " z wynikiem" + " " + employeeWithMaxResult.maxResult  );