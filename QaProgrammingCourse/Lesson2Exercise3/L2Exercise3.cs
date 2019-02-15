using System;
using System.Linq;

namespace Lesson2Exercise3
{
    public class L2Exercise3
    {
        static double GetNumber()
        {
            double sideLength;
            while (!double.TryParse(Console.ReadLine(), out sideLength)) {
                Console.WriteLine("Incorrect number entered.\nPlease try again:");
            }
            return sideLength;
        }

        static char GetOperator()
        {
            char [] operators = new char[5] { '+', '-', '/', '*', '^' };
            char sign = char.Parse(Console.ReadLine());
            if (!operators.Contains(sign)) {
                while (!operators.Contains(sign)) {
                    Console.WriteLine("Incorrect math operator entered.\nPlease try again:");
                    sign = char.Parse(Console.ReadLine());
                }
            }
            return sign;
        }

        static void Main()
        {
            Console.WriteLine("Welcome to regular calculator program!" +
                "\n Please enter two numbers and the mathematical operator.");
            Console.WriteLine("First number:");
            double a = GetNumber();
            Console.WriteLine("Second number:");
            double b = GetNumber();
            Console.WriteLine("Math operator (one of +, -, /, * or ^):");
            char sign = GetOperator();
            switch (sign)
            {
                case '+': {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-': {
                        Console.WriteLine(a - b);
                        break;
                    }
                case '/': {
                        if (b != 0) {
                            Console.WriteLine(a / b);
                        } else {
                            Console.WriteLine("Division by zero is not allowed!");
                        }
                        break;
                    }
                case '*': {
                        Console.WriteLine(a * b);
                        break;
                    }
                case '^': {
                        Console.WriteLine(Math.Pow(a, b));
                        break;
                    }
                default: { break; }
            }
            Console.ReadKey();
        }
    }
}
