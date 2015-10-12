using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            int shet = 0;
            int zad = 100;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Loss.Lost();
                    Console.SetCursorPosition(30, 13);
                    Console.WriteLine("Ваш счёт = " + shet);
                    Console.ReadLine();
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    shet++;
                }
                else
                {
                    snake.Move();
                }
                if (shet == 5)
                {
                    zad = 90;
                }

                if (shet == 6)
                {
                    zad = 80;
                }

                if (shet == 7)
                {
                    zad = 70;
                }

                if (shet == 8)
                {
                    zad = 60;
                }

                if (shet == 9)
                {
                    zad = 50;
                }

                Thread.Sleep(zad);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
