using System;
public class GoalDeleter
{  

    public GoalDeleter()
    {
    }
    
    public List<Goal> DeleteGoal(List<Goal> goals)
    {
        Console.WriteLine("The goals available to remove are:"); 
        int j = 1;
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"   {j}. {goal.GetName()}");
            j++;
        }
        Console.WriteLine("Which goal did you want to remove?" );
        int eventSelection = int.Parse(Console.ReadLine());
        goals.RemoveAt(eventSelection - 1);
        return goals;
    }
    
      
}