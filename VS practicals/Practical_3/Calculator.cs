using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    public delegate double calculate(double a, double b);
    public class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Modulus(double a, double b)
        {
            return a % b;
        }

        public static void Menu()
        {
            Console.WriteLine("Select an arithmatic operation");
            Console.WriteLine("1)Addition");
            Console.WriteLine("2)Subtraction");
            Console.WriteLine("3)Multiplication");
            Console.WriteLine("4)Division");
            Console.WriteLine("5)Remainder");
            Console.WriteLine("6)Quit");
        }
    }
}
