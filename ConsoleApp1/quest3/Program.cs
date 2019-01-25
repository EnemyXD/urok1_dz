using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите координаты x1");
            var x1var = Console.ReadLine();
            double x1 = double.Parse(x1var);

            Console.WriteLine("Введите координаты y1");
            var y1var = Console.ReadLine();
            double y1 = double.Parse(y1var);

            Console.WriteLine("Введите координаты x2");
            var x2var = Console.ReadLine();
            double x2 = double.Parse(x2var);

            Console.WriteLine("Введите координаты y2");
            var y2var = Console.ReadLine();
            double y2 = double.Parse(y2var);

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");

            Console.ReadKey();
        }
    }
}
