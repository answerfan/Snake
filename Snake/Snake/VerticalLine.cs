using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {

        List<Point> vList;

        public VerticalLine(int b, int cdown, int cup, char sym)
        {
            vList = new List<Point>();
            for (int c = cdown; c <= cup; c++)
            {
                Point p = new Point(b, c, sym);
                vList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Point p in vList)
            {
                p.Draw();
            }
        }
    }
}
