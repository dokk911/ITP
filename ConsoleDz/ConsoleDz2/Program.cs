using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Написать программу, которая будет выполняться до
            //тех пор, пока не будет введено слово exit. (сделать
            //не через break, а через условие, которое отвечает
            //за то, когда цикл должен завершиться)

            string text;

            do
            {
                Console.Write("Напишите фразу: ");
                text = Console.ReadLine();
            } while (text != "exit");
        }
    }
}
