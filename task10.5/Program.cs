using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите начальный пробег n (км): ");
        double n = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите процент увеличения m: ");
        double m = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите максимальный пробег k (км): ");
        double k = Convert.ToDouble(Console.ReadLine());

        double totalDistance = 0;
        int day = 0;

        while (totalDistance <= k)
        {
            day++;
            totalDistance += n;
            n += n * (m / 100);
        }

        Console.WriteLine($"Суммарный пробег превысит {k} км на {day}-й день.");
        Console.ReadKey();
    }
}