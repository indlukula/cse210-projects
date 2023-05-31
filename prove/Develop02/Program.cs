using System;
using System.IO;
 class Program
{
    static void Main(string[] args)
    {
        int action = 0;
        Console.Write("\n** How was your day? **\n");
        // Create new journal list
        Journal journal = new Journal();
        Prompts pr = new Prompts();
         while (action != 5)
        {
            // Ask user to choose (1-5)
            action = Options();
             switch (action)
            {
                case 1:
                    // Write Journal Capture
                    string captureId = GetCaptureId();
                    string dateInfo = GetDateTime();
                    string prompt = pr.GetPrompts();
                     JournalCapture capture = new JournalCapture();
                    capture._captureNo = captureId;
                    capture._dateTime = dateInfo;
                    capture._Prompts = prompt;
                     Console.Write($"{prompt}\n");
                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    capture._journalCapture = userEntry;
                     journal._journal.Add(capture);
                     break;
                case 2:
                    // Display Journal Entries
                    journal.Display();
                     break;
                case 3:
                    // Load text file
                    journal.LoadJournalFile();
                     break;
                case 4:
                    // Save to text file
                    journal.SaveJournalFile();
                    break;
                case 5:
                    // Exit
                    Console.WriteLine("\nThank you have a good day!\n");
                    break;
                default:
                    Console.WriteLine($"\nPlease select again.");
                    break;
            }
        }
    }
     static int Options()
    // Method to display Options to user
    {
        string Options = @"
                Please select one of the following options:
                1. Write
                2. Display
                3. Load
                4. Save
                5. Quit
                What would you like to do? ";
         Console.Write(Options);
        string userInput = Console.ReadLine();
        int action = 0;
        // Input error capture
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return action;
    }
     static string GetDateTime()
    // GetDateTime for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
         return currentDateTime;
    }
     static string GetCaptureId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();
         return entryuuidAsString;
    }
}