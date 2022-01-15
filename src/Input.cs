using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Input
    {
        public string Name = "Input";
        public string Value = Console.ReadLine();

        public void Display(string Context)
        {
            Console.WriteLine(Context + ": " + Value);
        }

        public void GetInput()
        {
            
        }

        public void Destroy()
        {

        }
    }
}
