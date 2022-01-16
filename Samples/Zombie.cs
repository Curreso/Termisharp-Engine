using System;

namespace TermisharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Termisharp.App application = new Termisharp.App();
            Termisharp.Player player = new Termisharp.Player();
            player.XPos = 10;

            Termisharp.Subject enemy = new Termisharp.Subject();
            enemy.Alias = "Zombie";
            enemy.XPos = 10;

            application.SetForegroundColor(ConsoleColor.DarkYellow);

            if (player.XPos == enemy.XPos)
            {
                Termisharp.Prompt choicePrompt = new Termisharp.Prompt();
                choicePrompt.Title = "Oh no! A zombie, would you like to try to run away or kill him?";
                choicePrompt.Display();

                if (choicePrompt.Value.ToLower() == "run away")
                {
                    Console.WriteLine("You ran away safely.");
                    player.Move(5, 0);
                } else if (choicePrompt.Value.ToLower() == "kill him")
                {
                    Console.WriteLine("You tried to kill him but he ate your brains!");
                } else
                {
                    Console.WriteLine("He killed you.");
                }
            }
        }
    }
}
