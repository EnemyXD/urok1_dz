using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Калмыков
//    5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

namespace quest5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите имя, фамилию и ваш город");
            string a = Console.ReadLine();
            
            Console.WriteLine("{0,50}", a);
            Console.ReadKey();

            string b = a;
            Print(b);

            Console.ReadKey();
        }

        static void Print(string y)
        {
            
            Console.WriteLine("{0,50}  \\вызвано методом", y);

        }
    }
}
