using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i;
        for (i = 1; i * i < n; i++) ;

        // Уменьшаем i на 1, так как цикл прекращается, когда i * i >= n
        i--;

        Console.WriteLine($"Первое натуральное число, квадрат которого меньше {n}: {i}");

        Console.ReadKey();
    }
}