using System;
using Xunit;
using Calculator;
namespace TestCases
{
    public class CalculatorTests
    {
        [Fact]
        public void on_providing_2_inputs_it_should_retuen_the_sum()
        {
            Calculatorr calculator = new Calculatorr();
            var actual = calculator.addition(4, 5);
            var expected = 9;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void subtraction_Test()
        {
            Calculatorr calculator = new Calculatorr();
            var actual = calculator.subtraction(10, 5);
            var expected = 5;
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void multiplication_Test()
        {
            Calculatorr calculator = new Calculatorr();
            var actual = calculator.multiplication(2, 5);
            var expected = 10;
            Assert.Equal(expected, actual);
        }
    }
}
