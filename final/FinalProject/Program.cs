using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        // Menu menu = new Menu();
        // menu.Start();
        Game _game = new Game();
        _game.StartGame();
        Scoreboard scoreboard = new Scoreboard();
        scoreboard._DisplayScores();
        // Dictionary dictionary = new Dictionary();
        // dictionary.LoadWordsFromFile();
        Player _player = new Player();
        _player.GetName();
        _player.GetScore();
        WordGuessingGame wordGuessingGame = new WordGuessingGame();
        
    }
   
}