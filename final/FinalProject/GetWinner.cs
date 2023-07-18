public class GetWinner
{
    public string FindWinner(List<Player> players)
    {
        string _winner = "";
        int _highestScore = 0;
         foreach (Player player in players)
        {
            if (player.GetScore() > _highestScore)
            {
                _highestScore = player.GetScore();
                _winner = player.GetName();
            }
        }
         return _winner;
    }
}