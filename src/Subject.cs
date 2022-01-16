using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Subject
    {
        // INHERITED FROM PLAYER //
        string Name = "Subject";
        public string Alias = "Subject";
        public string Description = "";
        public int XPos = 0;
        public int YPos = 0;
        public bool Vanished = false;

        // extra properties for different genres of games, this is completely customizable //
        // NOTE: if you would like to enable these properties then add a public in front of the variable data type
        int Health = 100;
        int MaxHealth = 100;
        int Level = 1;
        int CurrentXP = 0;
        int LevelUpXP = 25;

        public void Move(int x, int y)
        {
            if (!Vanished)
            {
                Console.ReadLine();

                XPos += x;
                YPos += y;
            }
        }

        public void Teleport(int x, int y)
        {
            if (!Vanished)
            {
                XPos = x;
                YPos = y;
            }
        }

        public void DisplayPosition()
        {
            if (!Vanished)
            {
                Console.WriteLine(XPos + "," + YPos);
            }
        }

        public void ToggleVanished()
        {
            if (!Vanished)
            {
                Vanished = true;
            } else
            {
                Vanished = false;
            }
        }

        public void Destroy()
        {

        }
    }
}
