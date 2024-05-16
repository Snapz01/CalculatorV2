using System;

namespace CalculatorV2
{
    public static class Calc
    {
        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtraction(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public static string Division(double number1, double number2)
        {
            if (number2 == 0)
            {
                return "Cannot divide by zero";
            }
            return (number1 / number2).ToString();
        }
    }
}
