using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class App
    {
        public string Name = "App";
        public ConsoleColor BackgroundColor = ConsoleColor.Black;
        public ConsoleColor ForegroundColor = ConsoleColor.White;

        public void SetBackgroundColor(ConsoleColor color)
        {
            BackgroundColor = color;
            Console.BackgroundColor = BackgroundColor;
        }

        public void SetForegroundColor(ConsoleColor color)
        {
            ForegroundColor = color;
            Console.ForegroundColor = ForegroundColor;
        }

        public void Destroy()
        {

        }
    }
}
