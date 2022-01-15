using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class BeepSequence
    {
        public string Name = "Base";
        public bool Beeping = false;

        public void Beep()
        {
            Beeping = true;
            Console.Beep();
            Beeping = false;
        }

        public void CreateSequence(int length)
        {
            if (length < 12 && length > 1)
            {
                for (int i = 1; i <= length; i++)
                {
                    Beeping = true;
                    Console.Beep();
                    Beeping = false;
                }
            } else if (length > 12)
            {
                Console.WriteLine("Error: BeepSequence Sequence must be less than 12 beeps.");
            } else if (length == 1)
            {
                Console.WriteLine("Error: BeepSequence sequence must be more than 1 beep. Use Beep() instead.");
            }
        }



        public void Destroy()
        {

        }
    }
}
