
namespace ChallengeApp

{
    public class Employee

    {
        private List<int> Score = new List<int>();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public Employee(string name, string surname, int age)

        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public int result
        {
            get
            {
                return Score.Sum();
            }
        }
        public void AddGrade(int grade) => Score.Add(grade);

    }

}





