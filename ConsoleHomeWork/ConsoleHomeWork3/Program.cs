using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа выводит число задом-наперед.

            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                int remainder = number % 10;
                number = number / 10;
                Console.Write(remainder);
            }

            Console.ReadKey();
        }
    }
}
