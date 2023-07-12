namespace CalculatorAppSpecFlow.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        CalculatorLogic calculator = new CalculatorLogic();
        public int actualResult;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            calculator.firstNumber = firstNumber;

        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            calculator.secondNumber = secondNumber;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            actualResult = calculator.Add();
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            actualResult = calculator.Subtract();
        }

        [When(@"the two numbers are multipled")]
        public void WhenTheTwoNumbersAreMultipled()
        {
            actualResult = calculator.Multiply();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            actualResult = calculator.Divide();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            actualResult.Should().Be(expectedResult);
        }
    }
}