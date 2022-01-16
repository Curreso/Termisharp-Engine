using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
{
    class Error
    {
        public string Name = "Error";
        public string ErrorContent;

        public void SetErrorContent(string err)
        {
            ErrorContent = err;
        }

        public void Write()
        {
            Console.WriteLine("Error: " + ErrorContent);
        }

        public void Destroy()
        {

        }
    }
}
