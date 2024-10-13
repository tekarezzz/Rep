using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(3, 11) + F(5, 13) + F(7, 17);
            Console.WriteLine(Math.Round(x, 3));
            Console.ReadKey();
        }


        static double F(double a, double b)
        {
            return (1 + (a * a)) / (1 + b * b);
        }
    }
}
