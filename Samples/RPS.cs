using System;

namespace TermisharpPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Termisharp.App Application = new Termisharp.App();
            Termisharp.Prompt Prompt = new Termisharp.Prompt();

            Prompt.Title = "Rock, Paper, Scissors, shoot!";
            Prompt.Display();

            string answer = GetConsoleAnswer(Prompt.Value);

            if (answer != null)
            {
                if (answer == Prompt.Value)
                {
                    Console.WriteLine("Tie");
                    return;
                }

                if (answer == "rock" && Prompt.Value == "scissors")
                {
                    Termisharp.Text Win = new Termisharp.Text();
                    Win.TextContent = "I chose " + answer + " and I win!";
                    Win.Display();
                } else if (answer == "paper" && Prompt.Value == "rock")
                {
                    Termisharp.Text Win = new Termisharp.Text();
                    Win.TextContent = "I chose " + answer + " and I win!";
                    Win.Display();
                } else if (answer == "scissors" && Prompt.Value == "paper")
                {
                    Termisharp.Text Win = new Termisharp.Text();
                    Win.TextContent = "I chose " + answer + " and I win!";
                    Win.Display();
                } else if (answer == "rock" && Prompt.Value == "paper")
                {
                    Termisharp.Text Lost = new Termisharp.Text();
                    Lost.TextContent = "Oof I chose " + answer + ", and you won.";
                    Lost.Display();
                } else if (answer == "paper" && Prompt.Value == "scissors")
                {
                    Termisharp.Text Lost = new Termisharp.Text();
                    Lost.TextContent = "Oof I chose " + answer + ", and you won.";
                    Lost.Display();
                } else if (answer == "scissors" && Prompt.Value == "rock")
                {
                    Termisharp.Text Lost = new Termisharp.Text();
                    Lost.TextContent = "Oof I chose " + answer + ", and you won.";
                    Lost.Display();
                }
            }

            string GetConsoleAnswer(string input)
            {
                Random rnd = new Random();

                int RandomNumber = rnd.Next(1, 3);
                
                if (RandomNumber == 1)
                {
                    return "rock";
                } else if (RandomNumber == 2)
                {
                    return "paper";
                } else if (RandomNumber == 3)
                {
                    return "scissors";
                }

                return null;
            }
        }
    }
}
