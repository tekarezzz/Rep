using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x:");
            var x = double.Parse(Console.ReadLine());

            var y = MyFunction(x);
            Console.WriteLine($"f(x) = {y}");

            Console.ReadKey();

        }


        static double MyFunction(double x)
        { return (Math.Tan(x) + Math.Sqrt(Math.Sin(x) * Math.Sin(x) + 4)) / (Math.Cos(x) * Math.Cos(x) + 4); }
    }
    }
}
