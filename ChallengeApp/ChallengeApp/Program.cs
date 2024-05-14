using ChallengeApp;
using System;
using System.Diagnostics;

var employee = new Employee("Seba", "Kot", 23);
employee.AddGrade("5");
employee.AddGrade(2000);
employee.AddGrade(7);
employee.AddGrade(0.5);
employee.AddGrade("Piotr");
employee.AddGrade(-2.5);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");




