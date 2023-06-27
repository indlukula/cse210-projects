using System;

public abstract class Goal
{
    // Attributes
    private string _goalType;
    private string _goalName;
    private string _description;
    private int _points;
    private bool _isComplete;


    // Constructors
    public Goal(string goalType, string goalName, string description, int points, bool isComplete)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }
    public string GetgoalType()
    {
        return _goalType;
    }
    public string GetgoalName()
    {
        return _goalName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetisComplete()
    {
        return _isComplete;
    }


    // Methods
    public abstract void ListGoal(int i);
    public abstract string goalType();
    public abstract string SaveGoal();
    public abstract string LoadGoal();
    public abstract bool isComplete();
    public abstract void RecordGoalEvent(List<Goal> goals);

}