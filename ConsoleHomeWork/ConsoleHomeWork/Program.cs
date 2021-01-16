using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит число, найти все делители этого числа.

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; number > i; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
