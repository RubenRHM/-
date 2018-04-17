using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.CSharp;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Configuration.AppConfig;
using calculator = Calculator;


namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private int result;
        
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            Calculator.FirstNumber = number;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            Calculator.SecondNumber = number;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = Calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            result = Calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = Calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            result = Calculator.Divide();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }

    }
}
