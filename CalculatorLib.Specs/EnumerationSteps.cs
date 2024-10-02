using Reqnroll;
using Xunit;

namespace CalculatorLib.Specs
{
    [Binding]
    public class EnumerationSteps
    {
        ShippingMethod shippingMethod;
        int shippingFee;
        Calculator calculator = new Calculator();

        [Given(@"the shipping method is '(.*)'")]
        public void GivenTheShippingMethodIs(ShippingMethod method)
        {
            shippingMethod = method;
        }

        [When(@"I press Calculate Shipping fee")]
        public void WhenIPressCalculateShippingFee()
        {
            shippingFee = calculator.CalculateShippingFee(shippingMethod);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedFee)
        {
            Assert.Equal(expectedFee, shippingFee);
        }
    }
}
