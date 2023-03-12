using System;
public class SimpleGoal : Goal
{  
    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points, isComplete)
    {
    } 

    public override void IsComplete()
    {
        SetComplete();
    }

    public override string DisplayGoal(Goal goal)
    {
        string displayString = "";
        if (goal.GetComplete() == true)
        {
            displayString = $"[X] {goal.GetName()} ({goal.GetDesc()})";
        }
        else
        {
            displayString = $"[ ] {goal.GetName()} ({goal.GetDesc()})";
        }
        return displayString;    
    }

    public override string GoalText(Goal goal)
    {
        string objectType = this.GetType().ToString();
        string goalString = $"{objectType}|{goal.GetName()}|{goal.GetDesc()}|{goal.GetPoints()}|{goal.GetComplete()}";    
        return goalString;
    }
}