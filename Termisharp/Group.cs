using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
{
    class Group
    {
        public string Name = "Group";
        public string Alias = "Unnamed";

        List<string> items = new List<string>();

        public void AddItem(string item)
        {
            // looping through everything in the arguments and adding them to THIS group

            items.Add(item);
        }

        public void Destroy()
        {

        }
    }
}
