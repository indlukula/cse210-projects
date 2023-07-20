public class Player
{
    private string _name;
    private int _score;
     public Player(string playerName)
    {
        _name = playerName;
        _score = 0;
    }
    public Player()
    {
    }

    public string GetName()
    {
        return _name;
    }
     public int GetScore()
    {
        return _score;
    }
     public void AddPoints(int points)
    {
        _score += points;
    }
     public void LosePoints(int points)
    {
        _score -= points;
    }
     public bool GuessWord(string word)
    {
        Console.Write("Enter your guess: ");
        string guess = Console.ReadLine();
         return guess.ToLower() == word.ToLower();
    }
}