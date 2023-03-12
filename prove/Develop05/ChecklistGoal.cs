using System;
public class ChecklistGoal : Goal
{  
    private int _goalTimes;
    private int _doneTimes;
    private int _bonus;
    public ChecklistGoal(int goalTimes, int bonus, string name, string description, int points, bool isComplete = false, int doneTimes = 0) : base(name, description, points, isComplete)
    {
        _goalTimes = goalTimes;
        _bonus = bonus;
        _doneTimes = doneTimes;
    } 

    public override void IsComplete()
    {
        _doneTimes++;
        if ((_doneTimes / _goalTimes) == 1)
        {
            SetComplete();
        }
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override string DisplayGoal(Goal goal)
    {
        string displayString = "";
        if ((_doneTimes / _goalTimes) == 1)
        {
            displayString = $"[X] {goal.GetName()} ({goal.GetDesc()}) — Currently completed: {_doneTimes} / {_goalTimes}";
        }
        else
        {
            displayString = $"[ ] {goal.GetName()} ({goal.GetDesc()}) — Currently completed: {_doneTimes} / {_goalTimes}";
        }
        return displayString;
    }

    public override string GoalText(Goal goal)
    {
        string objectType = this.GetType().ToString();
        string goalString = $"{objectType}|{goal.GetName()}|{goal.GetDesc()}|{goal.GetPoints()}|{_bonus}|{_goalTimes}|{_doneTimes}";
        return goalString;
    }
}