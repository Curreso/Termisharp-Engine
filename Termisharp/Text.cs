using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
{
    class Text
    {
        // Text object that can be displayed on the console.

        public string Name = "Text";
        public string TextContent = "Lorem Ipsum";
        public ConsoleColor TextColor = ConsoleColor.White;

        public void Display()
        {
            Console.ForegroundColor = TextColor;
            Console.WriteLine(TextContent);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SetColor(ConsoleColor color)
        {
            TextColor = color;
        }

        public void Destroy()
        {

        }
    }
}