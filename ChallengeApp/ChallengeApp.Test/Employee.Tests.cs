namespace ChallengeApp.Test
{
    public class TestEmployee
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectAverageGrades()
        {
            var employee = new Employee("Seba", "Kot", 23 );
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistic();
          
            Assert.AreEqual(4.6666665f , result.Average);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMaxGrade()
        {
            var employee = new Employee("Seba", "Kot", 23);
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistic(); 

            Assert.AreEqual(7 , result.Max);

        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinGrade()

        {
            var employee = new Employee("Seba", "Kot", 23);
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistic();
         
            Assert.AreEqual(2, result.Min);
            
        }
    }
}