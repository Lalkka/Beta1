using System;
using System.Text;

namespace Beta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int HP = 100, MaxHP = 100, Point = 0, Damage = 10, PosMineX = 3, PosMineY = 1, PosX = 2, PosY = 2;
            Console.WriteLine("#####");
            Console.WriteLine("#####");
            Console.WriteLine("#####");
            Console.WriteLine("#####");
            Console.WriteLine("#####");
            while (true)
            {


                //Задаем позицию
                Console.SetCursorPosition(PosX, PosY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("O");
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 5);

                //Строка состояния героя
                Console.WriteLine($"♡{HP}/{MaxHP}\n✧{Point}");

                //Получение урона
                if (PosX == PosMineX && PosY == PosMineY)
                {
                    HP -= Damage;
                    Console.WriteLine("Вы наступили на мину");
                }

                //Передвижение персонажа
                Console.WriteLine("Введите направление движения (W, A, S, D):");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("#");
                    PosX++;
                    Console.SetCursorPosition(PosX, PosY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 5);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("#");
                    PosY--;
                    Console.SetCursorPosition(PosX, PosY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 5);

                }
                else if (key.Key == ConsoleKey.A)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("#");
                    PosX--;
                    Console.SetCursorPosition(PosX, PosY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 5);
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Console.SetCursorPosition(PosX, PosY);
                    Console.Write("#");
                    PosY++;
                    Console.SetCursorPosition(PosX, PosY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("O");
                    Console.ResetColor();
                    Console.SetCursorPosition(0, 5);
                }
            }
        }
    }
}
