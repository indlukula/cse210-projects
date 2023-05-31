using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;
 public class Journal
{
    // variables
    public List<JournalCapture> _journal = new List<JournalCapture>();
    private string _userFile;
     // Display journal capture
    public void Display()
    {
        Console.WriteLine("\n******* Journal Capture ******");
        foreach (JournalCapture journalCapture in _journal)
        {
            journalCapture.Display();
        }
    }
     public void CreateJournalFile()
    {
        Console.Write("Please name your file: ");
        string userInput = Console.ReadLine();
        _userFile = userInput + ".txt";
         if (!File.Exists(_userFile))
        {
            File.CreateText(_userFile);
            Console.Write($"\n** {_userFile} successfully created! **\n");
            Console.Write("**  The journal has been saved. **\n");
            WriteToFile(_userFile, false);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n*** {_userFile} exits. ***\n");
            Console.Write("***  The journal capture has been added. ***\n");
            WriteToFile(_userFile, true);
        }
    }
     public void WriteToFile(string _userFile, bool append)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFile, append))
        {
            foreach (JournalCapture journalCapture in _journal)
            {
                outputFile.WriteLine($"{journalCapture._captureNo}; {journalCapture._dateTime}; {journalCapture._Prompts}; {journalCapture._journalCapture}");
            }
        }
    }
     public void LoadJournalFile()
    {
        Console.Write("Please enter your file name: ");
        string userInput = Console.ReadLine();
        _userFile = userInput + ".txt";
         if (File.Exists(_userFile))
        {
            using (StreamReader sr = new StreamReader(_userFile))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                     string[] captured = line.Split("; ");
                     JournalCapture capture = new JournalCapture();
                     capture._captureNo = captured[0];
                    capture._dateTime = captured[1];
                    capture._Prompts = captured[2];
                    capture._journalCapture = captured[3];
                     _journal.Add(capture);
                }
            }
        }
    }
     public void CreateJSON(string userInput)
    {
        string fileName = userInput + ".json";
        List<JsonFile> _data = new List<JsonFile>();
         foreach (JournalCapture journalCapture in _journal)
        {
            _data.Add(new JsonFile()
            {
                ID = journalCapture._captureNo,
                Date = journalCapture._dateTime,
                Prompt = journalCapture._Prompts,
                Capture = journalCapture._journalCapture
            });
        }
         string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

    internal void SaveJournalFile()
    {
        throw new NotImplementedException();
    }
}