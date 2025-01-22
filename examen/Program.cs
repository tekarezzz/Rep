using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            if (long.TryParse(Console.ReadLine(), out long num) && num > 0)
            {
                Console.WriteLine($"{num} = {PrimeFactors(num)}");
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите натуральное число больше 0.");
            }
            Console.ReadKey();
        }
        static string PrimeFactors(long num)
        {
            var result = new List<string>();
            int count = 0;
            while (num % 2 == 0)
            {
                count++;
                num /= 2;
            }
            if (count > 0) result.Add(count == 1 ? "2" : $"2^{count}");
            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                count = 0;
                while (num % i == 0)
                {
                    count++;
                    num /= i;
                }
                if (count > 0) result.Add(count == 1 ? i.ToString() : $"{i}^{count}");
            }
            if (num > 2)
            {
                result.Add(num.ToString());
            }
            return string.Join(" * ", result);
        }
    }
}
