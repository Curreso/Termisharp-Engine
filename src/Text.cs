using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
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

        public void SetColor(string color)
        {
            string lowered = color.ToLower();

            TextColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), lowered);
        }

        public void Destroy()
        {

        }
    }
}
