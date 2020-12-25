using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDz
{
    class Program
    {
        //1. Сделать самое первое дз на консоли(Эния)

        static void Main(string[] args)
        {
            int number, sizeLong, sizeWidth;

            Console.Write("введите кол - во панелей: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите высоту: ");
            sizeLong = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите ширину: ");
            sizeWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write($"ответ: ");
            Console.Write(number * sizeLong * sizeWidth * 2);

            Console.ReadKey();
        }
    }
}
