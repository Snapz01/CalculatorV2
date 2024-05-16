using Xunit;
using CalculatorV2;

namespace Calculator.Tests
{
    public class CalcTests
    {
        //Addition
        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, -3, -8)]
        [InlineData(5.5, 3.3, 8.8)]
        public void Addition(double number1, double number2, double expected)
        {
            // Act
            double result = Calc.Addition(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }
        //Subtraction
        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-5, -3, -2)]
        [InlineData(5.5, 3.3, 2.2)]
        public void Subtraction(double number1, double number2, double expected)
        {
            // Act
            double result = Calc.Subtraction(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }
        //Multiplication
        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(-5, -3, 15)]
        [InlineData(5.5, 3.3, 18.15)]
        public void Multiplication(double number1, double number2, double expected)
        {
            // Act
            double result = Calc.Multiplication(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }
        //Division error på 2,2> blir typ 8 extra decimaler av någon anledning?? får fel på test
        [Theory]
        [InlineData(6, 3, "2")]
        [InlineData(-6, -3, "2")]
        [InlineData(5.5, 2.2, "2.5")]
        public void Division(double number1, double number2, string expected)
        {
            // Act
            string result = Calc.Division(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }
        //Divide by zero
        [Theory]
        [InlineData(6, 0, "Can't divide by zero")]
        public void DivideByZero(double number1, double number2, string expected)
        {
            // Act
            string result = Calc.Division(number1, number2);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
