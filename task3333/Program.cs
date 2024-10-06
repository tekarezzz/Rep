using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырехзначное число: ");
            string input = Console.ReadLine();

            if (input.Length == 4 && int.TryParse(input, out int number))
            {
                int thousands = number / 1000;
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = number % 10;

                int sumOfDigits = thousands + hundreds + tens + units;

                Console.WriteLine($"Число десятков: {tens}");
                Console.WriteLine($"Число сотен: {hundreds}");
                Console.WriteLine($"Сумма цифр: {sumOfDigits}");
                Console.ReadKey();
            }
        }
    }
}
