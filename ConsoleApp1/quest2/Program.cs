using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//    2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах

namespace quest2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите ваш рост в метрах");
            var height = Console.ReadLine();
            double h = double.Parse(height);

            Console.WriteLine("Введите ваш вес в килограммах");
            var weight = Console.ReadLine();
            double m = double.Parse(weight);

            double i;

            i = m / (h * h);

            Console.WriteLine($"Индекс массы тела {i}");

            Console.ReadKey();
        }
    }
}
