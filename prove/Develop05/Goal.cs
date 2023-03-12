using System;

public abstract class Goal
{  
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;
    
    public Goal(string name, string description, int points, bool isComplete = false)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }  

    public bool GetComplete()
    {
        return _isComplete;
    }

    public void SetComplete()
    {
        _isComplete = true;
    }

    public abstract void IsComplete();    
    public abstract string DisplayGoal(Goal goal);    
    public abstract string GoalText(Goal goal);
    public virtual int GetBonus()
    {
        return 0;
    }
}