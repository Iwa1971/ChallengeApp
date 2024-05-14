using System.Diagnostics;

namespace ChallengeApp

{
    public class Employee

    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname, int age)

        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public void AddGrade(float grade)

        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("String is not Float");
            }

        }

        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(decimal grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }
        public Statistics GetStatistics()

        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade >= 0 && grade <= 100)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= this.grades.Count;

            return statistics;

        }

        public Statistics GetStatisticsWithForEach()

        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            return statistics;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
         
            for (var index = 0; index < grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min,grades[index]);
                statistics.Average += grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            } while (index < grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }
            statistics.Average /= this.grades.Count;

            return statistics;
        }

    }
}




