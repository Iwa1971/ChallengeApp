namespace ChallengeApp.Test
{
    public class Tests
    {
        [Test]
        public void WhenTwoGradeAreAdded_ShouldReturnSum()
        {
            var employee1 = new Employee("Anna", "Troska", 33);
            employee1.AddGrade(7);
            employee1.AddGrade(9);

            var result = employee1.result;

            Assert.AreEqual(16, result);
        }
        [Test]
        public void WhenNegativeGradesAreAdded_ShouldReturnSum()
        {
            var employee2 = new Employee("John", "Russo", 44);
            employee2.AddGrade(-17);
            employee2.AddGrade(-8);
            var result = employee2.result;
            Assert.AreEqual(-25, result);
        }
        [Test]

        public void WhereGradesAreAdded_ShouldReturnZero()

        {
            var employee3 = new Employee("Iwona", "Mak", 29);
            employee3.AddGrade(7);
            employee3.AddGrade(2);
            employee3.AddGrade(-9);
            var result = employee3.result;
            Assert.AreEqual(0, result);
        }
    }
}