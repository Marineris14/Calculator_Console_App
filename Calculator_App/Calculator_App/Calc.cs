using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public static class Calc
    {
        static public double Sum(double x, double y)
        {
            return x + y;
        }

        static public double Minus(double x, double y)
        {
            return x - y;
        }

        static public double Multiply(double x, double y)
        {
            return x * y;
        }

        static public double RestOfDivide(double x, double y)
        {
            return x % y;
        }

        static public double Divide(double x, double y)
        {
            while (y == 0)
            {
                Console.WriteLine("Can not divide by zero");
                return 0;
            }
            return x / y;
        }

        static public double Factorial(double x)
        {
            double factorial = x;

            if (x == 0)
            {
                return 1;
            }

            for (var i = x - 1; i > 1; i--)
            {
                factorial *= i;

            }
            return factorial;
        }

        static public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static public double Power(double x, double y)
        {
            double temp = 1;
            for (double i = 0; i < y; i++)
                temp *= x;
            return temp;
        }

        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = double.TryParse(numberString, out double numberDouble);
            while (!isDoubleInput)
            {
                Console.Write("Wrong input! Try again: ");
                numberString = Console.ReadLine();
                isDoubleInput = double.TryParse(numberString, out numberDouble);
            }
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator)
        {
            List<string> operatorWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorWithOneArgument = new List<string> { "sqrt", "!" };
            while (true)
            {
                mathOperator = Console.ReadLine();
                if (operatorWithSecondArgument.Contains(mathOperator))
                {
                    return true;
                }
                else if (operatorWithOneArgument.Contains(mathOperator))
                {
                    return false;
                }
                Console.WriteLine();
                Console.Write("Wrong input! Try again: ");
            }
        }
    }
}
