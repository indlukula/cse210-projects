public class Player
{
    private string name;
    private int score;
     public Player(string playerName)
    {
        name = playerName;
        score = 0;
    }
     public string GetName()
    {
        return name;
    }
     public int GetScore()
    {
        return score;
    }
     public void AddPoints(int points)
    {
        score += points;
    }
     public void LosePoints(int points)
    {
        score -= points;
    }
     public bool GuessWord(string word)
    {
        Console.Write("Enter your guess: ");
        string guess = Console.ReadLine();
         return guess.ToLower() == word.ToLower();
    }
}