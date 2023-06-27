using System;

public class ChecklistGoal : Goal
{
    // Attributes
    private string _goalType = "Check List Goal:";
    private int _numberTimes;
    private int _bonusPoints;
    private bool _isComplete;
    private int _count;


    // Constructors
    public ChecklistGoal(string goalType, string name, string description, int points, int numberTimes, int bonusPoints, bool isComplete) : base(goalType, name, description, points, isComplete)
    {
        _isComplete = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string goalType, string name, string description, int points, bool isComplete, int numberTimes, int bonusPoints, int count) : base(goalType, name, description, points, isComplete)
    {
        _isComplete = isComplete;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _goalType = goalType;
        _count = count;
    }
    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string goalType()
    {
        return _goalType;
    }

    public int GetTimes()
    {
        return _numberTimes;
    }
    public void SetTimes()
    {
        _count = _count + 1;
    }
     public int GetCount()
    {
        return _count;
    }
    public void SetCount()
    {

    }
     public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public Boolean Finished()
    {
        return _isComplete;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetgoalName()} ({GetDescription()})  --  Currently Completed: {GetCount()}/{GetTimes()}");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] {GetgoalName()} ({GetDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetgoalName()}; {GetDescription()}; {GetPoints()}; {_isComplete}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetgoalName()}; {GetDescription()}; {GetPoints()}; {_isComplete}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        SetTimes();
        int points = GetPoints();

        if (_count == _numberTimes)
        {
            _isComplete = true;
            points = points + _bonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

}