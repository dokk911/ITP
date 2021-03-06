using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDz4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создайте переменную типа string, в которой хранится пароль для доступа
            //к тайному сообщению. Пользователь вводит пароль, далее происходит проверка
            //пароля на правильность, и если пароль неверный, то попросите его ввести
            //пароль ещё раз. Если пароль подошёл, выведите секретное сообщение.
            //Если пользователь неверно ввел пароль 3 раза, программа завершается.

            string password = "1111", checkPassword;
            int count = 0;
            while (true)
            {
                do
                {
                    Console.Write("Введите пароль: ");
                    checkPassword = Console.ReadLine();
                    if (checkPassword != password)
                    {
                        count++;
                        Console.WriteLine("Пароль неверный!");
                    }
                } while (checkPassword != password && count < 3);

                if (count == 3)
                {
                    break;
                }

                if (checkPassword == password)
                {
                    Console.WriteLine("Секретное сообщение");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
