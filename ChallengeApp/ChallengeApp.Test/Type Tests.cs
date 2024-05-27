namespace ChallengeApp.Test
{
    internal class Type_Tests
    {
         
        [Test]

        public void WhenStringsAreSame()
        {
            var employee1 = GetEmployee("Anna", "Troska", "female");
            var employee2 = GetEmployee("Anna", "Troska", "female");
            Assert.AreSame(employee1.Name, employee2.Name);
        }
        [Test]
        public void WhenEmployeesAreDifferentl()
        {
            var employee1 = GetEmployee("Anna", "Troska", "female");
            var employee3 = GetEmployee("Iwona", "Mak", "female");
            Assert.AreNotSame(employee1, employee3);
        }
       private Employee GetEmployee(String name, string surname,string gender)
        {
            return new Employee(name, surname, gender);
        }
       
    }
}

