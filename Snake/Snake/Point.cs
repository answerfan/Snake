using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;

        public static void Func1(int value)
        {

        }

        public static void Func2(int value)
        {
            value = value + 1;
        }

        public static void Func3(int X)
        {
            X = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)
        {
            p = new Point();
        }

    }
}
