using System;

// A code template for the category of things known as 
public class JournalCapture
{
    public string _captureNo = "";
    public string _dateTime = "";
    public string _Prompts = "";
    public string _journalCapture = "";
    public string _journalFile = "";


    // A Constustor
    public JournalCapture()
    {
    }

    // displaying
    public void Display()
    {
        Console.WriteLine($"\n#: {_captureNo}");
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_Prompts}");
        Console.WriteLine($"Capture: {_journalCapture}");
    }

}