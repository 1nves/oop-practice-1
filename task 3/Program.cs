using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        delegate double AverageDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            AverageDelegate average = delegate (int a, int b, int c)
            {
                return (a + b + c) / 3.0;
            };

            double result = average(4, 6, 8);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
