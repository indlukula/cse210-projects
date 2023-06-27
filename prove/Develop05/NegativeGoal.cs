using System;
using System.Collections.Generic;
 public class NegativeGoal : Goal
{
    // Attributes
    private string _goalType = "Negative Goal";
    private bool _isComplete;
     // Constructors
    public NegativeGoal(string goalType, string goalName, string description, int points, bool isComplete) : base("Negative Goal", goalName, description, points, isComplete)
    {
        _isComplete = isComplete;
    }
     // Methods
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string goalType()
    {
        return _goalType;
    }

     public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetgoalName()} ({GetDescription()})");
    }
     public override string SaveGoal()
    {
        return $"{_goalType};{GetgoalName()};{GetDescription()};{GetPoints()};{_isComplete}";
    }
     public override string LoadGoal()
    {
        return $"{_goalType};{GetgoalName()};{GetDescription()};{GetPoints()};{_isComplete}";
    }
     public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Oops! You have lost {GetPoints()} points!");
    }
}