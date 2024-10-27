using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsStatementTrue(m, n))
                Console.WriteLine("Утверждение истинно");
            else
                Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }


        static bool IsStatementTrue(int m, int n)
        {
            return m == 0 | n == 0;
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
