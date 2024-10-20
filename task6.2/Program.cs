using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "телега";
            Console.WriteLine($"Из слова \"{s}\" получили");

            var word1 = s
                .Remove(0, 2) +
                s
                .Remove(1, 5);



            Console.WriteLine(word1);

            var word2 = s
                .Remove(0, 5) +
                s
                .Remove(1, 5) +
                s
                .Remove(0, 2)
                .Remove(2, 2) +
                s
                .Remove(1, 5);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
    }
}
