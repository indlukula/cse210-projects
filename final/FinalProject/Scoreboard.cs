using System;

public class Scoreboard
{
    public void DisplayScores(List<Player> players)
    {
        Console.WriteLine("Scores:");
         foreach (Player player in players)
        {
            Console.WriteLine(player.GetName() + " - " + player.GetScore() + " points");
        }
    }
}