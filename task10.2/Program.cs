using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество административных единиц: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double totalPopulation = 0;
        double totalArea = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Введите количество жителей (в тыс. чел.) для единицы {i}: ");
            double population = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите площадь (в кв. км) для единицы {i}: ");
            double area = Convert.ToDouble(Console.ReadLine());

            totalPopulation += population;
            totalArea += area;
        }

        double averageDensity = totalPopulation / totalArea;
        Console.WriteLine($"Средняя плотность населения: {averageDensity} тыс. чел. на кв. км");

        Console.ReadKey();
    }
}