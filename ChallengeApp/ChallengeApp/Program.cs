using ChallengeApp;
using System;
using System.Diagnostics;

Console.WriteLine("Witamy w Programie do liczenia statystyk Pracownikow");
Console.WriteLine("====================================================");
Console.WriteLine();

var employee = new Employee("Name", "Surname");
while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
   
}

var statistics = employee.GetStatistics();
Console.WriteLine($"averageLetter:{statistics.AverageLetter}");
Console.WriteLine($"Min:{statistics.Min}");
Console.WriteLine($"Max:{statistics.Max}");




