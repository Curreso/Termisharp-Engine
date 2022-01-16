using System;

namespace TermisharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Termisharp.Player Player = new Termisharp.Player();
            Termisharp.Prompt Prompt = new Termisharp.Prompt();
            Prompt.Title = "Enter /help for commands. Enter W or S to move.";
            Prompt.Display();

            InputController(Prompt.Value);

            void InputController(string input)
            {
                if (input != null)
                {
                    if (input.ToLower() == "/help")
                    {
                        Termisharp.Text helpCommand = new Termisharp.Text();
                        helpCommand.TextContent = "/tp <x, y>, /say <msg>";
                        helpCommand.Display();

                        Termisharp.Input userInput = new Termisharp.Input();
                        InputController(userInput.Value);
                    }
                    else if (input.ToLower() == "w")
                    {
                        Termisharp.Text reminder = new Termisharp.Text();
                        reminder.TextContent = "You moved 1 block on the X axis. Your current position is " + Player.GetPosition();
                        reminder.Display();

                        Player.Move(1, 0);

                        Termisharp.Input userInput = new Termisharp.Input();
                        InputController(userInput.Value);
                    }
                    else if (input.ToLower() == "s")
                    {
                        Termisharp.Text reminder = new Termisharp.Text();
                        reminder.TextContent = "You moved 1 block on the Y axis. Your current position is " + Player.GetPosition();
                        reminder.Display();

                        Player.Move(0, 1);

                        Termisharp.Input userInput = new Termisharp.Input();
                        InputController(userInput.Value);
                    }
                    else
                    {
                        Termisharp.Text reminder = new Termisharp.Text();
                        reminder.TextContent = "Enter /help for commands. Enter W or S to move.";

                        reminder.Display();
                    }
                }
            }
        }
    }
}
