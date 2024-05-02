namespace ChallengeApp.Test
{
    internal class Type_Tests
    {
        [Test]
        public void WhenIntigersAreDifferent()
        {
            var employee1 = GetEmployee("Anna", "Troska", 33);
            var employee2 = GetEmployee("Iwona", "Mak", 29);
            Assert.AreNotEqual(employee1.Age, employee2.Age);
        }
        [Test]

        public void WhenStringsAreSame()
        {
            var employee1 = GetEmployee("Anna", "Troska", 33);
            var employee2 = GetEmployee("Anna", "Troska", 33);
            Assert.AreSame(employee1.Name, employee2.Name);
        }
        [Test]
        public void WhenEmployeesAreDifferentl()
        {
            var employee1 = GetEmployee("Anna", "Troska", 33);
            var employee3 = GetEmployee("Iwona", "Mak", 29);
            Assert.AreNotSame(employee1, employee3);
        }
       private Employee GetEmployee(String name, string surname, int age)
        {
            return new Employee(name, surname,age);
        }
       
    }
}

