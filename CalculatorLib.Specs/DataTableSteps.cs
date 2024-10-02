using Reqnroll;
using Xunit;

namespace CalculatorLib.Specs
{
    [Binding]
    public class DataTableSteps
    {
        Person person;
        int age;
        Calculator calculator = new Calculator();

        [Given(@"I have entered the following person data")]
        public void GivenIHaveEnteredTheFollowingPersonData(Table table)
        {
            person = table.CreateInstance<Person>();
        }

        [When(@"I press Calculate age")]
        public void WhenIPressCalculateAge()
        {
            age = calculator.CalculateAge(person);
        }

        [Then(@"The result should be (.*) years")]
        public void ThenTheResultShouldBeYears(int expectedAge)
        {
            Assert.Equal(expectedAge, age);
        }

    }
}
