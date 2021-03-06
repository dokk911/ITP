using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console0603Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                Square(number);
                Console.WriteLine();
            }
        }

        public static int Square(int square)

        {
            square *= square;
            Console.WriteLine(square);
            return square;
        }
    }
}
