using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Совершенные числа, не превосходящие 10,000:");

        for (int num = 2; num <= 10000; num++)
        {
            int sumOfDivisors = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sumOfDivisors += i;
                }
            }

            if (sumOfDivisors == num)
            {
                Console.WriteLine(num);
                Console.ReadKey();
            }
        }
    }
}