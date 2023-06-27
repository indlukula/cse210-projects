using System;

public class EternalGoal : Goal
{
    // Attributes
    private string _goalType = "Eternal Goal:";
    private bool _isComplete;


    // Constructors
    public EternalGoal(string goalType, string name, string description, int points, bool isComplete) : base(goalType, name, description, points, isComplete)
    {
        _isComplete = false;
    }
    // public EternalGoal(string type, string name, string description, int points, bool status) : base(goalType, name, description, points)
    // {
    //     _isComplete = status;
    // }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string goalType()
    {
        return _goalType;
    }

    // Methods

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetgoalName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{goalType}; {GetgoalName()}; {GetDescription()}; {GetPoints()}; {_isComplete}");
    }
    public override string LoadGoal()
    {
        return ($"{goalType}; {GetgoalName()}; {GetDescription()}; {GetPoints()}; {_isComplete}");
    }
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }


}