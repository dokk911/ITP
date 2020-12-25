﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDz2
{
    class Program
    {
        //2. При старте программы пользователь вводит начальное количество золота.Потом ему предлагается 
        //купить какое-то количество кристаллов по цене N(задать в программе самому). Пользователь вводит 
        //число и его золото конвертируется в кристаллы.Остаток золота и кристаллов выводится на экран.
        //ОБЯЗАТЕЛЬНО, чтоб нельзя было закупиться на большую сумму чем есть в кошельке

        static void Main(string[] args)
        {
            int gold = 0, crystals = 0;

            Console.Write("Введите кол - во золота: ");
            gold = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Вы можете обменять ваше золото({gold}) на кристаллы, да/нет: ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case ("да"):
                    Console.WriteLine("Курс обмена - 3 золота");
                    Console.Write("Напишите кол - во кристаллов: ");
                    crystals = Convert.ToInt32(Console.ReadLine());

                    if (gold - crystals * 3 >= 0)
                    {
                        gold = gold - crystals * 3;

                        Console.WriteLine("Успешно!");
                        Console.WriteLine($"Золото: {gold}");
                        Console.WriteLine($"Кристалы: {crystals}");
                    }
                    else
                    {
                        Console.WriteLine("Не хватает золота!");
                    }
                    break;
                case ("нет"):
                    Console.WriteLine($"Золото: {gold}");
                    Console.WriteLine($"Кристалы: {crystals}");
                    break;
            }

            Console.ReadKey();
        }
    }
}
