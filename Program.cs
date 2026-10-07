using System;
using System.Text;

namespace Beta1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int HP = 100, MaxHP = 100, Point = 0,
                Damage = 10, PosMineX = 3, PosMineY = 1,
                PosPointX0 = 0, PosPointY0 = 4,
                PosPointX1 = 3, PosPointY1 = 1,
                PosX = 2, PosY = 2;
            Console.WriteLine("Найдите 5 кристалов");
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

                //Нахождение поинтов
                if (PosX == PosPointX0 && PosY == PosPointY0)
                {
                    Point++;
                    Console.WriteLine("Вы Нашли кристал");
                }
                if (PosX == PosPointX1 && PosY == PosPointY1)
                {
                    Point++;
                    Console.WriteLine("Вы Нашли кристал");
                }
                if (Point >= 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы Нашли все кристалы!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                //Получение урона
                if (PosX == PosMineX && PosY == PosMineY)
                {
                    HP -= Damage;
                    Console.WriteLine("Вы наступили на мину");
                }
                if (HP <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Вы Мертвы");
                    Console.ReadLine();
                    Environment.Exit(0);
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
