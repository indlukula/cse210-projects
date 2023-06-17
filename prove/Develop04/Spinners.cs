using System;
using System.Diagnostics;
using System.Threading;
 public class Spinner
{
    // Attributes 
    int counter;
     // Methods
    public void Stopwatch()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < 10)
        {
            Console.Write("+");
             Thread.Sleep(1000);
             Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
        timer.Stop();
    }
     private void ConsoleSpinner()
    {
        counter = 0;
    }
    public void Turn()
    {
        counter++;
        switch (counter % 4)
        {
            case 0: Console.Write("=>"); break;
            case 1: Console.Write("==>"); break;
            case 2: Console.Write("===>"); break;
            case 3: Console.Write("====>"); break;
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
     public void ShowPercentage()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.Write($"\rGet Ready... {i}%   ");
            ShowSpinnerWithLoadingBar(i);
            Thread.Sleep(50);
        }
        Console.Write("\rGet Ready...      ");
    }
     public void ShowSpinnerWithLoadingBar(int percentage)
    {
        int barWidth = 50;
        int progress = (int)Math.Round((double)(barWidth * percentage) / 100.0);
         Console.Write("[");
        for (int i = 0; i < barWidth; i++)
        {
            if (i < progress)
            {
                Console.Write("=");
            }
            else
            {
                Console.Write(" ");
            }
        }
        Console.Write($"] {percentage}%");
         // Move the cursor back to the beginning of the loading bar
        Console.SetCursorPosition(Console.CursorLeft - (barWidth + 4), Console.CursorTop);
    }

   
    // ... (rest of the code remains unchanged)
}