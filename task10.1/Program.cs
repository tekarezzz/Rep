using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите действительное число x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double sum = 0;

        for (int i = 0; i <= n; i++)
        {
            int exponent = 2 * i + 1;
            sum += Math.Pow(x, exponent) / exponent;
        }

        Console.WriteLine($"Сумма: {sum}");

        Console.ReadKey();
    }
}