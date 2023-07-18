using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string> { "apple", "banana", "orange" };
        int maxGuesses = 3;
        int maxAttempts = 3;
         Console.Write("Enter the number of players: ");
        int numPlayers = Convert.ToInt32(Console.ReadLine());
         WordGuessingGame game = new WordGuessingGame(words, maxGuesses, maxAttempts);
         for (int i = 1; i <= numPlayers; i++)
        {
            Console.Write("Enter player " + i + "'s name: ");
            string playerName = Console.ReadLine();
            game.AddPlayer(new Player { Name = playerName });
        }
         game.Play();
    }
    List<string> players = new List<string>() { "Player1", "Player2", "Player3" };
    GetWinner game = new GetWinner();
    string winner = game.FindWinner(players);

    Console.WriteLine("The winner is: " + winner.Name);
    Console.WriteLine("The high score: " + winner.highestScore);
}