using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class ConsoleColors
    {
        public void ColorObject(string text, ConsoleColor t)
        {
            Console.ForegroundColor = t;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
