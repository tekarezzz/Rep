using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 1 катет:");
            Double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите 2 катет:");
            Double B = Convert.ToDouble(Console.ReadLine());
            double C = (Math.Sqrt((A * A) + (B * B)) / 2);
            Console.WriteLine("Длина медианы:" + Math.Round(C, 2));
            Console.ReadKey();
        }
    }
}
