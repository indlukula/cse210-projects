using System;
public class WordGuessingGame :Game
{
    private List<Player> players;
    private List<string> words;
    private int maxGuesses;
    private int maxAttempts;
    private int currentWordIndex;
    private int currentPlayerIndex;
    public WordGuessingGame (List<string> wordList, int guesses, int attempts)
    {
        words = wordList;
        maxGuesses = guesses;
        maxAttempts = attempts;
        players = new List<Player>();
        currentWordIndex = 0;
        currentPlayerIndex = 0;
    }
    public void AddPlayer(Player player)
    {
        players.Add(player);
    }
    public override void Play()
    {
        Console.WriteLine("Welcome to the Word Guessing Game");
        foreach (Player player in players)
        {
            Console.WriteLine("Player: " + player.Name);
            Console.WriteLine();
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.WriteLine("Attempt: " + attempt);
                string currentWord = words[currentWordIndex];
                string revealedWord = GetRevealedWord(currentWord, attempt);
                Console.WriteLine("Current Word: " + revealedWord);
                Console.WriteLine("Guesses Remaining: " + maxGuesses);
                Console.Write("Enter your guess: ");
                string guess = Console.ReadLine();
                if (guess.ToLower() == currentWord.ToLower())
                {
                    Console.WriteLine("Congratulations! You guessed the word correctly.");
                    player.Score += 20;
                     if (attempt == 1)
                     {
                        player.Score += 20; // Bonus for guessing on the first attempt
                     }
                    Console.WriteLine("Player Score: " + player.Score);
                    Console.WriteLine();
                     if (currentPlayerIndex < players.Count - 1)
                     {
                         currentPlayerIndex++;
                     }
                     else
                     {
                        currentPlayerIndex = 0;
                        if (currentWordIndex < words.Count - 1)
                        {
                            currentWordIndex++;
                        }
                        else
                        {
                            break;
                        }
                     }
                     attempt--; // Allow the player to guess again
                }
                else
                {
                    Console.WriteLine("Incorrect guess. Try again.");
                    maxGuesses--;
                    if (maxGuesses == 0)
                    {
                        Console.WriteLine("Out of guesses. The correct word was: " + currentWord);
                        player.Score -= 5;
                        Console.WriteLine("Player Score: " + player.Score);
                        Console.WriteLine();
                        if (currentPlayerIndex < players.Count - 1)
                        {
                            currentPlayerIndex++;
                        }
                        else
                        {
                            currentPlayerIndex = 0;
                            if (currentWordIndex < words.Count - 1)
                            {
                                currentWordIndex++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
// Find and display the winner
        Player winner = GetWinner();
        Console.WriteLine("The winner is: " + winner.Name);
        Console.WriteLine("High Score: " + winner.Score);
         foreach (Player player in players)
        {
            if (player != winner)
            {
                player.Score += 50; // Bonus for participating
            }
        }
         Console.WriteLine("Final Scores:");
        foreach (Player player in players)
        {
            Console.WriteLine("Player: " + player.Name);
            Console.WriteLine("Score: " + player.Score);
            Console.WriteLine();
        }

     private string GetRevealedWord(string word, int attempt)
    {
        if (attempt == 1)
        {
            string revealedWord = "";
            Random random = new Random();
             for (int i = 0; i < word.Length; i++)
            {
                if (i == 0 || i == 1)
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
        else if (attempt > 1 && attempt <= 4)
        {
            string revealedWord = "";
            Random random = new Random();
             for (int i = 0; i < word.Length; i++)
            {
                if (i < 2)
                {
                    revealedWord += word[i];
                }
                else if (random.Next(2) == 0)
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
        else
        {
            return word;
        }
    }
    
