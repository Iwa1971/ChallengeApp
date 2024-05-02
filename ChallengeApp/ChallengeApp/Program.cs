using ChallengeApp;
using System;

var employee = new Employee("Seba", "Kot", 23);
employee.AddGrade("5");
employee.AddGrade(2000);
employee.AddGrade(7);
employee.AddGrade(0.5);
employee.AddGrade("Piotr");
employee.AddGrade(-2.5);

var statistic = employee.GetStatistic();

Console.WriteLine($"Average: {statistic.Average}");
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");

