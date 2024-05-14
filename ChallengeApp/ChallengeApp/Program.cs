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
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine("Statistic with metod Foreach");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

Console.WriteLine("Statistic with metod For");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max:{statistics}");
Console.WriteLine($"Min:{statistics}");

Console.WriteLine("Statistic with metod Do and While");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max:{statistics}");
Console.WriteLine($"Min:{statistics}");

Console.WriteLine("Statistic with metod While");
Console.WriteLine($"Average:{statistics.Average:N2}");
Console.WriteLine($"Max:{statistics}");
Console.WriteLine($"Min:{statistics}");


