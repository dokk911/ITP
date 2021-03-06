using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDz3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. При помощи всего, что вы изучили, создать приложение, которое может
            //обрабатывать команды. Т.е. вы создаете меню, ожидаете ввода нужной команды
            //после чего выполняете действие, которое присвоено этой команде.
            //Примеры команд(требуется 4 - 6 команд, придумать самим)

            string login, password, checkPassword, country = "нет", number = "нет";

            Console.WriteLine("Процесс создания аккаунта...");

            do
            {
                Console.Write("Придумайте Логин: ");
                login = Console.ReadLine();
            } while (login == string.Empty);

            do
            {
                Console.Write("Придумайте Пароль: ");
                password = Console.ReadLine();
            } while (password == string.Empty);

            Console.WriteLine(" ");

            while (true)
            {
                Console.WriteLine("Команды:\nNumber - выбрать номер тел.\nCountry - выбрать страну\nInfo - вся информация\nEsc - выход");
                Console.Write("Выберите команду: ");
                string text = Console.ReadLine();
                Console.WriteLine(" ");

                if (text == "Number")
                {
                    do
                    {
                        Console.Write("Введите Пароль: ");
                        checkPassword = Console.ReadLine();
                    } while (checkPassword == string.Empty);

                    while (checkPassword != password)
                    {
                        Console.WriteLine("Пароль неверный!");
                        Console.Write("Введите Пароль: ");
                        checkPassword = Console.ReadLine();
                    }

                    Console.Write("Введите Номер Телефона (Россия): ");
                    number = Console.ReadLine();

                    while (number.Length != 11)
                    {
                        Console.WriteLine("Неверный формат!");
                        Console.Write("Введите Номер Телефона (Россия): ");
                        number = Console.ReadLine();
                    }

                    Console.WriteLine("Номер Телефона установлен!");
                    Console.WriteLine(" ");
                }

                if (text == "Country")
                {
                    do
                    {
                        Console.Write("Выберите Страну: ");
                        country = Console.ReadLine();
                    } while (country == string.Empty);

                    Console.WriteLine("Страна установлена!");
                    Console.WriteLine(" ");
                }

                if (text == "Info")
                {
                    do
                    {
                        Console.Write("Введите Пароль: ");
                        checkPassword = Console.ReadLine();
                    } while (checkPassword == string.Empty);

                    while (checkPassword != password)
                    {
                        Console.WriteLine("Пароль неверный!");
                        Console.Write("Введите Пароль: ");
                        checkPassword = Console.ReadLine();
                    }

                    Console.WriteLine($"Логин: {login}\nПароль: {password}\nТелефон: {number}\nСтрана: {country}");
                    Console.WriteLine(" ");
                }

                if (text == "Esc")
                {
                    break;
                }
            }
        }
    }
}
