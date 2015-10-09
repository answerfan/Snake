using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine uLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine dLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine lLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rLine = new VerticalLine(78, 0, 24, '+');
            uLine.Draw();
            dLine.Draw();
            lLine.Draw();
            rLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
           

        }
        
    }
}
