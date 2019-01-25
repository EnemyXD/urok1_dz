using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Какая у вас фамилия?");
            string second_name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            var age = Console.ReadLine();

            Console.WriteLine("Какой у вас рост?");
            var height = Console.ReadLine();

            Console.WriteLine("Какой у вас вес?");
            var weight = Console.ReadLine();

            Console.WriteLine(name + " " + second_name + " " + age + " " + height + " " + weight);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, second_name, age, height, weight);
            Console.WriteLine($"{name} {second_name} {age} {height} {weight}");


            Console.ReadLine();

        }
    }
}
