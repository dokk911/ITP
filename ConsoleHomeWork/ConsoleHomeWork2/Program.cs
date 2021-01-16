using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Найти количество разрядов числа. 2 - один, 34 - два, 234 - 3 и тд.

            int score = 0;
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                number = number / 10;
                score++;

                if(number == 0)
                {
                    Console.WriteLine(score);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
