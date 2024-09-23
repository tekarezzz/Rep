using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Судьба");

            Console.WriteLine();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Ты говоришь: «Она не стоит свеч,");
            Console.WriteLine("Игра судьбы. Темны её сплетенья».");
            Console.WriteLine("Но не бывает лишних встреч,");
            Console.WriteLine("И неслучайны совпаденья.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
