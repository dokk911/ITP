using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDz4
{
    class Program
    {
        //4. Вы задаете вопросы пользователю, по типу "как вас зовут",
        //"какой ваш знак зодиака" и тд, после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.
        //"Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе."

        static void Main(string[] args)
        {
            Console.Write("Как вас зовут?: ");
            string name = Console.ReadLine();

            Console.Write("Сколько вам лет?: ");
            string old = Console.ReadLine();

            Console.Write("Какой ваш знак зодиака?: ");
            string zodiac = Console.ReadLine();

            Console.Write("Кем вы работаете?: ");
            string work = Console.ReadLine();

            Console.Write("Вам нравится ваша работа? да/нет: ");
            string likeWork = Console.ReadLine();

            if (likeWork == "да")
            {
                likeWork = "нравится";
            }
            if (likeWork == "нет")
            {
                likeWork = "не нравится";
            }

            Console.WriteLine(" ");

            Console.WriteLine($"Вас зовут {name}, вам {old} лет, по знаку ходиака вы {zodiac}.\nВы работаете {work}, ваша работа вам {likeWork}.");

            Console.ReadKey();
        }
    }
}
