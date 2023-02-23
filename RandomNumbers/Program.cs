using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Program
    {
        public static double CalculateAverage(Func<int>[] delegates)
        {
            int sum = 0;
            foreach (var del in delegates)
            {
                sum += del();
            }
            return (double)sum / delegates.Length;
        }

        static void Main(string[] args)
        { 
            var delegates = new Func<int>[]
            {

                () => new Random().Next(50),
                () => new Random().Next(50),
                () => new Random().Next(50)
            };

            var result = CalculateAverage(delegates);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
