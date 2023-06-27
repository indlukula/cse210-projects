using System;

public class SimpleGoal : Goal
{
    // Attributes
    private string _goalType = "Simple Goal:";
    private bool _isComplete;

    // Constructors
    public SimpleGoal(string goalType, string goalName, string description, int points, bool isComplete) : base(goalType, goalName, description, points, isComplete)
    {
        _isComplete = false;
    }
    // public SimpleGoal(string goalType, string goalName, string description, int points, bool isComplete) : base(goalType, goalName, description, points)
    // {
    //     _isComplete = isComplete;
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
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetgoalName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetgoalName()} ({GetDescription()})");
        }
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
       _isComplete = true;
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public Boolean Finished()
    {
        return _isComplete;
    }
}