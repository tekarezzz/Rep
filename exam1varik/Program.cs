using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam1varik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            if (long.TryParse(Console.ReadLine(), out long num) && num > 0)
            {
                string factors = GetFactors(num);
                Console.WriteLine($"{num} = {factors}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите натуральное число больше 0.");
            }

            Console.ReadKey();
        }

        static string GetFactors(long num)
        {
            string result = "";

            for (long i = 2; i <= num; i++)
            {
                int count = 0;
                while (num % i == 0)
                {
                    count++;
                    num /= i;
                }
                if (count > 0)
                {
                    if (result != "") result += " * ";
                    result += count == 1 ? i.ToString() : $"{i}^{count}";
                }
            }

            return result;
        }
    }
}
