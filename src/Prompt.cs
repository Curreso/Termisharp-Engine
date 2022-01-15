using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Prompt
    {
        public string Name = "Prompt";
        public string Title = "";
        public string Value;

        public void Display()
        {
            Console.WriteLine(Title);
            Value = Console.ReadLine();
        }

        public void Destroy()
        {

        }
    }
}
