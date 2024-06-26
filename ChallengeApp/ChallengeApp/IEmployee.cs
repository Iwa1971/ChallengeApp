﻿
namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        int Age { get; }
        string Gender { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(double grade);
        void AddGrade(decimal grade);
        void AddGrade(long grade);
        Statistics GetStatistics();
    }
}
