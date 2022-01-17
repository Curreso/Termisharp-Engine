using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Termisharp
{
    class Player
    {
        public string Name = "Player";
        public string Alias = "Player";
        public string Description = "";
        public int XPos = 0;
        public int YPos = 0;
        List<string> PlayerTable = new List<string>();

        public void Move(int x, int y)
        {
            Console.ReadLine();

            XPos += x;
            YPos += y;
        }

        public void Teleport(int x, int y)
        {
            XPos = x;
            YPos = y;
        }
        
        public string GetPosition()
        {
            return XPos + "," + YPos;
        }

        public void CreateCharacterCreationSession()
        {
            Text question1 = new Text();
            question1.TextContent = "What is your character's name?\n";
            question1.Display();

            Input answer1 = new Input();

            Alias = answer1.Value;

            //

            Text question2 = new Text();
            question1.TextContent = "Would you like to add a backstory/description to your character?\n";
            question1.Display();

            Input answer2 = new Input();

            if (answer2.Value.ToLower() == "yes")
            {
                Text fieldTxt = new Text();
                fieldTxt.TextContent = "What will your character's backstory/description be?\n";
                fieldTxt.Display();

                Input answer3 = new Input();

                Description = answer3.Value;
            } else if (answer2.Value.ToLower() == "no")
            {
                Text completionAlert = new Text();
                completionAlert.TextContent = "Character successfully created.";
                completionAlert.Display();
            } else
            {
                Text err = new Text();
                err.TextContent = "Sorry, please select a yes or no answer.";
                err.Display();
            }
        }
        
        public void Destroy()
        {

        }
    }
}
