using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
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
        
        public void SmoothWrite(int delay)
        {
            foreach (char ch in Title + "\n")
            {
                Thread.Sleep(delay);
                Console.Write(ch);
            }
        }

        public void Destroy()
        {

        }
    }
}
