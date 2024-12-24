using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число (все цифры различны): ");
        int number = Convert.ToInt32(Console.ReadLine());

        int minDigit = 10;
        int position = 0;
        int index = 1;

        while (number > 0)
        {
            int digit = number % 10;

            if (digit < minDigit)
            {
                minDigit = digit;
                position = index;
            }

            number /= 10;
            index++;
        }

        Console.WriteLine($"Порядковый номер минимальной цифры: {position}");
        Console.ReadKey();
    }
}