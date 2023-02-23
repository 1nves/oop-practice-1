using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> Add = (x, y) => x + y;
            Func<double, double, double> Sub = (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) => y == 0 ? throw new Exception() : (x / y);


            Console.Write("Choose operation (+, -, *, /): ");
            string op = Console.ReadLine();
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {Add(num1,num2)}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} + {num2} = {Sub(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} + {num2} = {Mul(num1, num2)}");
                    break;
                case "/":
                    try
                    {
                        Console.WriteLine($"{num1} + {num2} = {Div(num1, num2)}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                    }
                    break;
                default:
                    Console.WriteLine("Error: unknown operation.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
