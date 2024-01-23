using ChallangeApp;

var employee = new Employee("Anna", "Bujak");
employee.AddGrade(2);
employee.AddGrade(3);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: + {statistics.Average:N2}");
Console.WriteLine($"Min : + {statistics.Min}");
Console.WriteLine($"Max : + {statistics.Max}");