using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//    4. Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

namespace quest4
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = Console.ReadLine();
            int x = int.Parse(a);

            var b = Console.ReadLine();
            int y = int.Parse(b);

            Console.WriteLine($"{x} {y}");
            Console.ReadKey();

            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"{x} {y}");

            Console.ReadKey();

            //с двумя переменными 
            int u = int.Parse(a);
            int t = int.Parse(b);

            u = u + t;
            t = u - t;
            u = u - t;

            Console.WriteLine($"{u} {t}");

            Console.ReadKey();

        }
    }
}
