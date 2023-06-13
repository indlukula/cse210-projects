using System;
using System.Collections.Generic;
using System.IO;
class Program
{
        static void Main(string[] args)
        {
       // Load scriptures from a file
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadFromFile("scriptures.txt");
         // Main loop
        while (true)
        {
            // Select a random scripture from the library
            Scripture scripture = library.GetRandomScripture();
             // Display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetFullText());
             // Prompt the user to press enter or type quit
            Console.WriteLine("\nPress ENTER to hide some words or type QUIT to exit.");
            string input = Console.ReadLine().Trim().ToUpper();
            if (input == "QUIT")
            {
                break;
            }
             // Hide some random words
            scripture.HideRandomWords();
             // Keep hiding words until all are hidden
            while (!scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetFullText());
                Console.WriteLine("\nPress ENTER to hide more words or type QUIT to exit.");
                input = Console.ReadLine().Trim().ToUpper();
                if (input == "QUIT")
                {
                    return;
                }
                scripture.HideRandomWords();
            }
        }
    }     
    }