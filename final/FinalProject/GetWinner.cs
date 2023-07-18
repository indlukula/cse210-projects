public class GetWinner
{
    public string FindWinner(List<Player> players)
    {
        string winner = "";
        int highestScore = 0;
         foreach (Player player in players)
        {
            if (player.GetScore() > highestScore)
            {
                highestScore = player.GetScore();
                winner = player.GetName();
            }
        }
         return winner;
    }
}