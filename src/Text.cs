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

        public void Display()
        {
            Console.WriteLine(TextContent);
        }

        public void Destroy()
        {

        }
    }
}
