using Reqnroll;
using Xunit;

namespace CalculatorLib.Specs
{
    [Binding]
    public class CalculateAgeExamplesSteps
    {
        string _name;
        DateTime birthdate;
        int age;
        Calculator calculator = new Calculator();

        [Given(@"I have entered a '(.*)'")]
        public void GivenIHaveEnteredA(string name)
        {
            _name = name;
        }

        [Given(@"I have also entered a '(.*)'")]
        public void GivenIHaveAlsoEnteredA(string strBirthdate)
        {
            birthdate = DateTime.Parse(strBirthdate);
        }

        [When(@"I press button Calculate age")]
        public void WhenIPressButtonCalculateAge()
        {
            age = calculator.CalculateAge(new Person() { Name = _name, BirthDate = birthdate });
        }

        [Then(@"The result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedAge)
        {
            Assert.Equal(expectedAge, age);
        }
    }
}
