using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//    3.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

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
