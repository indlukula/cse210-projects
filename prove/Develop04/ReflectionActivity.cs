using System;
using System.Collections.Generic;
using System.Diagnostics;
 public class ReflectingActivity : Activity
{
    // Attributes 
    private readonly List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you failed at something."
    };
    private readonly List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was your motivation?"
    };
    private readonly List<string> _useQuestionsList = new List<string>();
    private readonly string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
     // Constructors
    public ReflectingActivity(string activityName, int activityTime) : base(activityName, activityTime)
    {
    }
     // Methods
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }
     private static readonly Random _random = new Random();
     private string GetRandomPrompt()
    {
        int index = _random.Next(_promptList.Count);
        return _promptList[index];
    }
     private string GetRandomQuestion()
    {
        int index = _random.Next(_useQuestionsList.Count);
        return _useQuestionsList[index];
    }
     public void ShowPrompt(int seconds)
    {
        Console.WriteLine();
        var prompt = GetRandomPrompt();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
         var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
     public void ShowQuestion(int seconds)
    {
        _useQuestionsList.Clear();
        _useQuestionsList.AddRange(_questionList);
        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        CountDown(8);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        int index = 0;
        while (timer.Elapsed.TotalSeconds < seconds && index < _useQuestionsList.Count)
        {
            var question = GetRandomQuestion();
            Console.Write($"\n>> {question}  ");
            _useQuestionsList.Remove(question);
            index++;
        }
        timer.Stop();
    }
     private static void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            System.Threading.Thread.Sleep(1000);
        }
    }
}