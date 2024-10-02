using Reqnroll;
using Xunit;

namespace CalculatorLib.Specs
{
    [Binding]
    public class DataTableWithMultipleObjectsSteps
    {
        List<Person> persons;
        int age;
        Calculator calculator = new Calculator();

        [Given(@"I have entered the following list of person data")]
        public void GivenIHaveEnteredTheFollowingListOfPersonData(Table table)
        {
            persons = table.CreateSet<Person>() as List<Person>;
        }

        [When(@"I press Calculate age of the first person")]
        public void WhenIPressCalculateAgeOfTheFirstPerson()
        {
            age = calculator.CalculateAge(persons[0]);
        }

        [Then(@"The result should be (.*) years for the first person")]
        public void ThenTheResultShouldBeYearsForTheFirstPerson(int expectedAge)
        {
            Assert.Equal(expectedAge, age);
        }
    }
}
