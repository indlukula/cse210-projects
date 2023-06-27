using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Use to convert text to title case
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
         GoalManagement goals = new GoalManagement();
         Console.Write("\n*** Welcome to the Goals Tracker Program ****\n");
         Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
        //Call MainMenu
        Main choice = new Main();
        //Call GoalMenu
        GoalMenu goalChoice = new GoalMenu();
         int action = 0;
        while (action != 6)
        {
            Console.Clear();  // This will clear the console
            Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
             // Ask for user input (1-6)
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    // Create New Goal
                    int goalInput = 0;
                    while (goalInput != 5)
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                string name = GetTitleCasedInput("What is the name of your goal?  ", textInfo);
                                string description = GetTitleCasedInput("What is a short description of your goal?  ", textInfo);
                                int points = GetIntInput("What is the amount of points associated with this goal?  ");
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points, false);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                // Eternal Goal
                                name = GetTitleCasedInput("What is the name of your goal?  ", textInfo);
                                description = GetTitleCasedInput("What is a short description of your goal?  ", textInfo);
                                points = GetIntInput("What is the amount of points associated with this goal?  ");
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points, false);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                // Checklist Goal
                                name = GetTitleCasedInput("What is the name of your goal?  ", textInfo);
                                description = GetTitleCasedInput("What is a short description of your goal?  ", textInfo);
                                points = GetIntInput("What is the amount of points associated with this goal?  ");
                                int numberTimes = GetIntInput("How many times does this goal need to be accomplished for a bonus?  ");
                                int bonusPoints = GetIntInput("What is the bonus for accomplishing it that many times?  ");
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints, false);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                // Negative Goal
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points should be subtracted for not meeting this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                NegativeGoal nGoal = new NegativeGoal("Negative Goal:", name, description, points, false);
                                goals.AddGoal(nGoal);
                                goalInput = 5;
                                break;
                             case 5:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry the option you entered is not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // List Goals
                    goals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    // Quite
                    Console.WriteLine("\nThank you for using the Eternal Quest Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }
     private static string GetTitleCasedInput(string prompt, TextInfo textInfo)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();
        return textInfo.ToTitleCase(input);
    }
     private static int GetIntInput(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write(prompt);
        }
        return result;
    }
}