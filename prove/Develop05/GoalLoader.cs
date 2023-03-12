using System;
using System.IO; 
public class GoalLoader
{  

    public GoalLoader()
    {
    }    
    
    public string FileOpener()
    {
        Console.WriteLine("What is your goal file called?");
        string fileName = Console.ReadLine();
        string fullFilename = $"{fileName}.txt";
        return fullFilename;
    }
    
    public int LoadScore(string fileName)
    {
        int score = 0;
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist. Please try again.\n");
        }
        else if (File.Exists(fileName))
        {        
            using(StreamReader sr = File.OpenText(fileName))
            {
                score = int.Parse(sr.ReadLine());                
            }  
        }     
        return score;
    }
    
    public List<Goal> LoadGoals(List<Goal> goals, string fullName)
    {               
        if (File.Exists(fullName))
        {
            using(StreamReader sr = File.OpenText(fullName))
            {
                sr.ReadLine();
                string s = "";
                while ((s = sr.ReadLine()) != null) {
                // while (!sr.EndOfStream) {                                      
                    string[] parts = s.Split("|");
                    string goalType = parts[0];
                    string goalName = parts[1];
                    string goalDesc = parts[2];
                    int goalPoints = int.Parse(parts[3]);

                    if (String.Equals(goalType, "SimpleGoal"))
                    {
                        bool goalComplete = bool.Parse(parts[4]);
                        Goal simpleGoal = new SimpleGoal(goalName, goalDesc, goalPoints, goalComplete);
                        goals.Add(simpleGoal);
                    }
                    else if (String.Equals(goalType, "EternalGoal"))
                    {
                        Goal eternalGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                        goals.Add(eternalGoal);
                    }
                    else if (String.Equals(goalType, "ChecklistGoal"))
                    {
                        int goalBonus = int.Parse(parts[4]);
                        int goalDoTimes = int.Parse(parts[5]);
                        int goalDoneTimes = int.Parse(parts[6]);
                        bool isComplete = false;
                        Goal checklistGoal = new ChecklistGoal(goalDoTimes, goalBonus, goalName, goalDesc, goalPoints, isComplete, goalDoneTimes);
                        goals.Add(checklistGoal);                      
                    }                                       
                }
            }
            Console.WriteLine($"Goals from {fullName} now loaded \n");              
        }       
        return goals;     
    }
}