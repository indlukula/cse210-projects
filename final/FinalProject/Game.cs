public class Game
{
    private List<Player> _players;
    private Dictionary<int, string> _words;
    private int _currentPlayerIndex;
    private int _currentWordIndex;
    private int _currentAttempt;
    private int _totalPlayers;
    private bool _gamePaused;
     public Game()
    {
        _players = new List<Player>();
        _words = new Dictionary<int, string>();
        _currentPlayerIndex = 0;
        _currentWordIndex = 0;
        _currentAttempt = 0;
        _totalPlayers = 0;
        _gamePaused = false;
    }
     public void StartGame()
    {
        LoadWordsFromFile();
         Console.WriteLine("Welcome to the Word Guessing Game!");
         // Get number of players
        Console.Write("Enter the number of players: ");
        _totalPlayers = Convert.ToInt32(Console.ReadLine());
         // Create players
        for (int i = 0; i < _totalPlayers; i++)
        {
            Console.Write($"Enter the name of Player {i + 1}: ");
            string playerName = Console.ReadLine();
            _players.Add(new Player(playerName));
        }
         // Start game loop
        while (_currentWordIndex < _words.Count)
        {
            if (!_gamePaused)
            {
                Console.WriteLine($"\nCurrent Word: {GetMaskedWord(_words[_currentWordIndex])}");
                 // Check if player has guessed the word correctly
                if (_players[_currentPlayerIndex].GuessWord(_words[_currentWordIndex]))
                {
                    _players[_currentPlayerIndex].AddPoints(20);
                    Console.WriteLine("Congratulations! You guessed the word correctly.");
                    Console.WriteLine($"Current Score: {_players[_currentPlayerIndex].GetScore()}");
                     _currentAttempt = 0;
                    _currentWordIndex++;
                     if (_currentWordIndex == _words.Count)
                    {
                        EndGame();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Please try again.");
                     _currentAttempt++;
                     if (_currentAttempt == 3)
                    {
                        Console.WriteLine("You couldn't guess the word. Revealing 3 random letters.");
                         _players[_currentPlayerIndex].LosePoints(5);
                         string revealedWord = GetRevealedWord(_words[_currentWordIndex]);
                        Console.WriteLine($"Revealed Word: {revealedWord}");
                    }
                }
                 _currentPlayerIndex = (_currentPlayerIndex + 1) % _totalPlayers;
            }
            Console.WriteLine("\n1. Guess Word");
            Console.WriteLine("2. Pause Game");
            Console.WriteLine("3. Quit Game");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
             switch (choice)
            {
                case 1:
                    _gamePaused = false;
                    break;
                case 2:
                    _gamePaused = true;
                    Console.WriteLine("Game paused. Press any key to resume.");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Game quit.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    
     private string GetMaskedWord(string word)
    {
        string maskedWord = "";
         for (int i = 0; i < word.Length; i++)
        {
            if (i < 2)
            {
                maskedWord += word[i];
            }
            else
            {
                maskedWord += "_";
            }
        }
         return maskedWord;
    }
     private string GetRevealedWord(string word)
    {
        string revealedWord = "";
         Random random = new Random();
        List<int> indices = new List<int>();
         for (int i = 0; i < 3; i++)
        {
            int index = random.Next(2, word.Length);
             while (indices.Contains(index))
            {
                index = random.Next(2, word.Length);
            }
             indices.Add(index);
        }
         for (int i = 0; i < word.Length; i++)
        {
            if (indices.Contains(i))
            {
                revealedWord += word[i];
            }
            else
            {
                revealedWord += "_";
            }
        }
         return revealedWord;
    }
     private void LoadWordsFromFile()
    {
        try
        {
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                string line;
                int index = 0;
                 while ((line = sr.ReadLine()) != null)
                {
                    _words.Add(index, line);
                    index++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred while loading words from file: " + e.Message);
        }
    }
     private void EndGame()
    {
        Console.WriteLine("\nGame Over!");
         int maxScore = 0;
        List<Player> winners = new List<Player>();
         foreach (var player in _players)
        {
            player.AddPoints(50);
             if (player.GetScore() > maxScore)
            {
                maxScore = player.GetScore();
                winners.Clear();
                winners.Add(player);
            }
            else if (player.GetScore() == maxScore)
            {
                winners.Add(player);
            }
        }
         Console.WriteLine("\nScores:");
         foreach (var player in _players)
        {
            Console.WriteLine($"{player.GetName()}: {player.GetScore()}");
        }
         Console.WriteLine("\nWinner(s):");
         foreach (var winner in winners)
        {
            Console.WriteLine(winner.GetName());
        }
    }
}