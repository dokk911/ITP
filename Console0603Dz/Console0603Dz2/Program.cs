using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console0603Dz2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("WriteError / WriteWarning / WriteColor: ");
                string answer = Console.ReadLine();
                string text = Console.ReadLine();

                switch (answer)
                {
                    case "WriteError":
                        WriteError(text);
                        break;
                    case "WriteWarning":
                        WriteWarning(text);
                        break;
                    case "WriteColor":
                        WriteColor(text);
                        break;
                }

                Console.ResetColor();
            }
        }

        public static string WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            return message;
        }

        public static string WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            return message;
        }

        public static string WriteColor(string message)
        {
            string color = Console.ReadLine();

            switch (color)
            {
                case "Gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "White":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
            }

            Console.WriteLine(message);
            return message;
        }
    }
}
