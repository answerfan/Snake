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
            Console.Clear();
            Console.SetCursorPosition(30, 12);
            Console.WriteLine("Вы проиграли, сожалеем!");
        }
    }
}
