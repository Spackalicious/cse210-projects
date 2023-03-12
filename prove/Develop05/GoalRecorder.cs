using System;
public class GoalRecorder
{  

    public GoalRecorder()
    {
    }
    
    public Goal SelectGoal(List<Goal> goals)
    {
        Console.WriteLine("The goals are:"); 
        int j = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"   {j}. {goal.GetName()}");
            j++;
        }
        Console.WriteLine("Which goal did you accomplish?" );
        int eventSelection = int.Parse(Console.ReadLine());
        Goal goalSelection = goals[eventSelection - 1];
        return goalSelection;
    }
    
    public void RecordGoal(Goal selectedGoal)
    {        
        selectedGoal.IsComplete();
        string name = selectedGoal.GetName();
        int pts = selectedGoal.GetPoints();
        Console.WriteLine($"Congratulations on completing {name} for {pts} points!");
        Console.WriteLine();
    }

    public int RecordScore(Goal pickedGoal, int score)
    {
        int addPoints = pickedGoal.GetPoints();
        score += addPoints;
        string objectType = pickedGoal.GetType().ToString();
        bool completed = pickedGoal.GetComplete();
        if (objectType == "ChecklistGoal" && completed)
        {
            int bonusPoints = pickedGoal.GetBonus();
            score += bonusPoints;
            Console.WriteLine($"You've also earned a bonus {bonusPoints} points for completing your Checklist goal!\n");
        }
        return score;
    }   
}