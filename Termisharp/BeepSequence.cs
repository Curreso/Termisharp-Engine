using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
{
    class BeepSequence
    {
        public string Name = "BeepSequence";
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
                Error longLengthError = new Error();
                longLengthError.SetErrorContent("BeepSequence Sequence must be less than 12 beeps.");
                longLengthError.Write();
            } else if (length == 1)
            {
                Error shortLengthError = new Error();
                shortLengthError.SetErrorContent("BeepSequence Sequence must be more than 1 beep. Use Beep() instead.");
                shortLengthError.Write();
            }
        }

        public void Destroy()
        {

        }
    }
}
