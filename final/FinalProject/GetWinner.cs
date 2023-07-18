using System;
using System.Collections.Generic;

public class GetWinner
{
    public string FindWinner(List<string> players)
    {
        Dictionary<string, int> playerScores = new Dictionary<string, int>();
        //Assign initialscore of 0 to each player
        foreach (string player in players)
        {
            playerScores[player] = 0;

        }

        //Simulating somescores for demo purposes
        Random random = new Random();
        foreach (string player in players)
        {
            playerScores[player] += random.Next(1, 100);
        }

        
        //Find the player with the highest score
        string winner = "";
        int highestScore = 0;
        foreach (var playerScore in playerScores)
        {
            if (playerScore.Value > highestScore)
            {
                highestScore = playerScore.Value;
                winner = playerScore.Key;
            }
        }
        return winner;
    }
}