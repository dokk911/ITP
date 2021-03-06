using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDz5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести имя в прямоугольнике из символа, который введет
            //сам пользователь. Вы запрашиваете имя, после запрашиваете
            //символ, а после отрисовываете в консоль его имя в прямоугольнике из его символов.
            //Пример:
            //Alexey
            //%
            //%%%%%%
            //%Alexey%
            //%%%%%%

            string text, sign;
            int quantity, i = 0;

            Console.Write("Введите текст: ");
            text = Console.ReadLine();
            Console.Write("Введите символ: ");
            sign = Console.ReadLine();
            quantity = text.Length;

            while (i < quantity + 1)
            {
                Console.Write(sign);
                i++;
            }

            i = 0;
            Console.WriteLine(sign);
            Console.WriteLine($"{sign}{text}{sign}");

            while (i < quantity + 2)
            {
                Console.Write(sign);
                i++;
            }

            Console.ReadKey();
        }
    }
}
