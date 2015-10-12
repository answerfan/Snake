using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Loss : Program
    {
                        
        internal static void Lost()
        {
            int xOtst = 25;
            int yOtst = 8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xOtst, yOtst++);
            WriteText("Конец Игры", xOtst + 1, yOtst++);
            yOtst++;
        }
        static void WriteText(String text, int xOtst, int yOtst)
        {
            Console.SetCursorPosition(xOtst, yOtst);
            Console.WriteLine(text);
        }
    }
}
