using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDz
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. При помощи циклов вы можете повторять один и тот же код множество раз.
            //Напишите простейшую программу, которая выводит указанное(установленное)
            //пользователем сообщение заданное количество раз.

            int i = 0;
            Console.Write("Напишите фразу: ");
            string text = Console.ReadLine();
            Console.Write("Сколько раз повторять: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            while (i < quantity)
            {
                Console.WriteLine(text);
                i++;
            }

            Console.ReadKey();
        }
    }
}
