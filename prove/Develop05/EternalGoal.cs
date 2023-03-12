using System;
public class EternalGoal : Goal
{  
    public EternalGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points, isComplete)
    {
    } 

    public override void IsComplete()
    {
        // This doesn't do anything - Eternal goals remain in play.
    }

    public override string DisplayGoal(Goal goal)
    {
        string displayString = $"[ ] {goal.GetName()} ({goal.GetDesc()})";  
        return displayString;      
    }

    public override string GoalText(Goal goal)
    {
        string objectType = this.GetType().ToString();
        string goalString = $"{objectType}|{goal.GetName()}|{goal.GetDesc()}|{goal.GetPoints()}";    
        return goalString;
    }
}