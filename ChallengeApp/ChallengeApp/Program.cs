using ChallengeApp;
using System;

Employee employee1 = new Employee("Anna", "Troska", 33);
Employee employee2 = new Employee("John", "Russo", 44);
Employee employee3 = new Employee("Iwona", "Mak", 29);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
}



employee1.AddGrade(7);
employee1.AddGrade(9);
employee1.AddGrade(16);
employee1.AddGrade(11);
employee1.AddGrade(2);

employee2.AddGrade(17);
employee2.AddGrade(8);
employee2.AddGrade(11);
employee2.AddGrade(21);
employee2.AddGrade(12);

employee3.AddGrade(1);
employee3.AddGrade(19);
employee3.AddGrade(6);
employee3.AddGrade(10);
employee3.AddGrade(12);

    var maxResult = 0;
    Employee EmployeeWithMaxResult = null!;

    foreach (var employee in employees)

    { 
        if (employee.result > maxResult)
        {
             maxResult = employee.result;
             EmployeeWithMaxResult = employee;   
        }
    }

Console.WriteLine("Employee with the best Result");
Console.WriteLine("Name:" + EmployeeWithMaxResult.name);
Console.WriteLine("Surname:" + EmployeeWithMaxResult.surname);
Console.WriteLine("Age:" + EmployeeWithMaxResult.age);
Console.WriteLine("Points:" + EmployeeWithMaxResult.result);

