using System;
public class Scoreboard
{
    public void _DisplayScores(List<Player> _players)
    {
        Console.WriteLine("Scores:");
         foreach (Player player in _players)
        {
            Console.WriteLine(player.GetName() + " - " + player.GetScore() + " points");
        }
    }

    internal void _DisplayScores()
    {
       
    }
}