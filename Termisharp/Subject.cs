using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
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
                if (x <= 20 && y <= 20)
                {
                    XPos += x;
                    YPos += y;
                }
                else
                {
                    Error movementError = new Error();
                    movementError.ErrorContent = $"You may only move {Alias} by 20 maximum on each axis.";
                    movementError.Write();
                }
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

        public string GetPosition()
        {
            return XPos + "," + YPos;
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
