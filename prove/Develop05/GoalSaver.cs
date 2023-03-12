using System;
using System.IO; 
public class GoalSaver
{  

    public GoalSaver()
    {
    }
    
    public void SaveGoal(List<Goal> _goals, int totalScore)
    {
        Console.WriteLine("Where would you like to save your goals?");
        string _goalFileName = Console.ReadLine();
        string goalFile = $@"{_goalFileName}.txt";
        using (StreamWriter sw = new StreamWriter(goalFile))
        {                     
            sw.WriteLine($"{totalScore}");
            foreach (Goal goal in _goals)
            {
                sw.WriteLine($"{goal.GoalText(goal)}"); 
            }                                           
        }
        Console.WriteLine($"Entries saved to {_goalFileName}.txt \n"); 
    }

    
}