using Reqnroll;
using Xunit;

namespace CalculatorLib.Specs
{
    [Binding]
    public class AddExamplesSteps
    {
        int firstNumber, secondNumber, sum;

        Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int a)
        {
            firstNumber = a;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int b)
        {
            secondNumber = b;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            sum = calculator.Add(firstNumber, secondNumber);
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedSum)
        {
            Assert.Equal(expectedSum, sum);
        }
    }
}
