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
                if (shet == 10)
                {
                    zad = 85;
                }

                if (shet == 20)
                {
                    zad = 75;
                }

                if (shet == 30)
                {
                    zad = 65;
                }

                if (shet == 40)
                {
                    zad = 50;
                }

                if (shet == 50)
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 10);
                    Console.WriteLine("Вы безумный задрот и играть с Вами дальше не интересно - Вы победили!!!");
                    break;
                }

                Thread.Sleep(zad);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

            }
            Console.SetCursorPosition(26, 11);
            Console.WriteLine("Ваш счёт " + shet);
            Console.ReadLine();
        }

        
    }
}
