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
            //Will change tomorrow
            Func<double,double,double> Add = (x,y) => x + y;
            Func<double, double, double> Sub= (x, y) => x - y;
            Func<double, double, double> Mul = (x, y) => x * y;
            Func<double, double, double> Div = (x, y) =>
            {
                if (y != 0)
                {
                    return x / y;
                }
                else throw new Exception("'Y' can't be zero");
            };

            Console.WriteLine(Add(2, 56));
            Console.WriteLine(Sub(2, 3));
            Console.WriteLine(Mul(84,3));
            Console.WriteLine(Div(34,4));
            Console.ReadLine();
        }
    }
}
