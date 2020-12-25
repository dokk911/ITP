using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDz3
{
    class Program
    {
        //3. Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.
        //Пользователь вводит кол-во людей в очереди.
        //Фиксированное время приема одного человека всегда равно 10 минутам.
        //Пример ввода: Введите кол-во старушек: 14
        //Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."

        static void Main(string[] args)
        {
            Console.Write("Введите кол - во людей: ");
            int people = Convert.ToInt32(Console.ReadLine());

            int min = people * 10;
            int hour = 0;

            if (min >= 60)
            {
                hour = min / 60;
                min = min - hour * 60;
            }

            if (hour >= 1)
            {
                if (min == 0)
                {
                    Console.WriteLine($"Вы должны отстоять в очереди: {hour} ч");
                }
                else
                { 
                Console.WriteLine($"Вы должны отстоять в очереди: {hour} ч {min} мин");
                }
            }
            else
            {
                Console.WriteLine($"Вы должны отстоять в очереди: {min} мин");
            }

            Console.ReadKey();
        }
    }
}
