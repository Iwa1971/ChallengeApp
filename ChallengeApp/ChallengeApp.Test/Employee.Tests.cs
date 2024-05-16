namespace ChallengeApp.Test
{
    public class TestEmployee
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnCorrectAverageGrades()
        {
            var employee = new Employee("Seba", "Kot");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(4.6666665f, result.Average);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMaxGrade()
        {
            var employee = new Employee("Seba", "Kot");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(7, result.Max);

        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinGrade()

        {
            var employee = new Employee("Seba", "Kot");
            employee.AddGrade(5);
            employee.AddGrade(2);
            employee.AddGrade(7);

            var result = employee.GetStatistics();

            Assert.AreEqual(2, result.Min);

        }
        [Test]

        public void WhenEmployeecollectGradesInPoints_ShouldReturnCorrectAverageLetter()
        {
            //arrange
            var employee = new Employee("Kamil", "Kotek");
            employee.AddGrade(80);
            employee.AddGrade(40);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual('B', statistics.AverageLetter);

        }
        [Test]

        public void WhenEmployeesCollectGradesInLetter_ShouldShowCorrectMinPoints()
        {
            var employee = new Employee("Kamil", "Kotek");
            employee.AddGrade('B');
            employee.AddGrade('d');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(40, statistics.Min);
        }
        [Test]

        public void WhenEmployeesCollectGradesInLetter_ShouldShowCorrectMaxPoints()
        {
            var employee = new Employee("Kamil", "Kotek");
            employee.AddGrade('B');
            employee.AddGrade('d');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(80, statistics.Max);
        }
    }
}
