using System;
using CalculatorV2;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            // Menu
            Console.Clear();
            Console.WriteLine("------------Calculator------------");
            Console.WriteLine("Enter the selection you want to do:");
            Console.WriteLine();
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine();
            Console.WriteLine("Press 9 to exit the calculator");
            Console.Write("\r\nSelect an option: ");

            // Keypress
            switch (Console.ReadLine())
            {
                case "1":
                    CalcMenu("Addition");
                    return true;
                case "2":
                    CalcMenu("Subtraction");
                    return true;
                case "3":
                    CalcMenu("Multiplication");
                    return true;
                case "4":
                    CalcMenu("Division");
                    return true;
                case "9":
                    return false;
                default:
                    return true;
            }
        }

        static void CalcMenu(string mathOperation)
        {
            try
            {
                Console.Clear();
                Console.Write("Enter the first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                string result;
                switch (mathOperation)
                {
                    case "Addition":
                        result = Calc.Addition(number1, number2).ToString();
                        break;
                    case "Subtraction":
                        result = Calc.Subtraction(number1, number2).ToString();
                        break;
                    case "Multiplication":
                        result = Calc.Multiplication(number1, number2).ToString();
                        break;
                    case "Division":
                        result = Calc.Division(number1, number2);
                        break;
                    default:
                        result = "??";
                        break;
                }

                // varför blir resultatet så många decimaler??
                Console.WriteLine("Result " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input.\n Please enter valid numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
