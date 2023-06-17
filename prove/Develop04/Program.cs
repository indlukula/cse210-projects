using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        // This will clear the console
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        //Call Choices
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            // Ask for user input (1-4)
            action = choice.userChoices();
            switch (action)
            {
                case 1:
                    // Start Breathing Activity
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing Activity", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    //breathing.GetReadyToStart();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    //Start Reflecting Activity
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetActivityTime();
                    //reflecting.GetReadyToStart();
                    reflecting.ShowPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    //Start Listing Activity
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing Activity", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetActivityTime();
                    //listing.GetReadyToStart();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    // Quite
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
class Choices
{
    public int userChoices()
    {
        Console.WriteLine("\nPlease choose an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
         int choice = int.Parse(Console.ReadLine());
        return choice;
    }


    }
    

}