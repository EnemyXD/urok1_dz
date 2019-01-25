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

            //Расчет обычным способом
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");

            //Расчет методом
            
            double z = Raschet(x1, x2, y1, y2);

            Console.WriteLine($"{z:F2} с помощью метода");

            Console.ReadKey();
        }



        static double Raschet(double a1, double a2, double b1, double b2)
        {
     
            double q = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            return q;

        }
    }
}
