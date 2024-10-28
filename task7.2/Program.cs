using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для x:");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение для y:");
            var y = int.Parse(Console.ReadLine());
            Console.WriteLine(IsInArea(x, y));
            Console.ReadKey();
        }
        static bool IsInArea(int x, int y)
        {
            return (x < -2) && (y > 1);
        }
    }
}
