using System;

class Program
{    
    static void Main(string[] args)
    {
        int _score = 0;
        List<Goal> _goals = new List<Goal>();
        string _menuSelection;
        
        do {
            Console.WriteLine($"You have {_score} points. \n");
            Console.WriteLine("   1. Create New Goals");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Remove Goal");
            Console.WriteLine("   7. Quit");
            Console.Write("Select a choice from the menu: ");
            _menuSelection = Console.ReadLine();

            switch (_menuSelection)
                {                    
                    case "1":
                        Console.WriteLine("The types of Goals are:"); 
                        Console.WriteLine("   1. Simple Goal");
                        Console.WriteLine("   2. Eternal Goal");
                        Console.WriteLine("   3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        string goalType = Console.ReadLine();
                        if (goalType == "1" | goalType == "2" | goalType == "3")
                        {
                            Console.Write("What is the name of your goal? ");
                            string name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            int points = int.Parse(Console.ReadLine());
                            switch (goalType)
                            {                       
                                case "1":                                        
                                    Goal simpleGoal = new SimpleGoal(name, description, points);
                                    _goals.Add(simpleGoal);
                                    Console.WriteLine("\nNew simple goal added:");      
                                    Console.WriteLine($"{simpleGoal.DisplayGoal(simpleGoal)}\n");                          
                                break;
                                case "2":
                                    Goal eternalGoal = new EternalGoal(name, description, points);
                                    _goals.Add(eternalGoal);
                                    Console.WriteLine();
                                break;
                                case "3":
                                    Console.Write("How many times do you want to accomplish this goal? ");
                                    int goalTimes = int.Parse(Console.ReadLine());
                                    Console.Write("How many bonus points will you receive once you've completed this goal? ");
                                    int bonus = int.Parse(Console.ReadLine());
                                    Goal checklistGoal = new ChecklistGoal(goalTimes, bonus, name, description, points);
                                    _goals.Add(checklistGoal);
                                    Console.WriteLine();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Whoops! You've entered an invalid response. Let's start again!\n");
                        }                                                                  
                    break;  
                    case "2":
                        Console.WriteLine("\nThe goals are: "); 
                        int i = 1;
                        foreach (Goal goal in _goals)
                            {
                                Console.WriteLine($"{i}. {goal.DisplayGoal(goal)}");
                                i++;
                            }   
                        Console.WriteLine();                    
                    break;  
                    case "3":
                        Console.WriteLine("You have selected Save Goals");    
                        GoalSaver gs = new GoalSaver();
                        gs.SaveGoal(_goals, _score);                         
                    break;  
                    case "4":
                        Console.WriteLine("You have selected Load Goals");
                        GoalLoader gl = new GoalLoader();
                        string file = gl.FileOpener();
                        _score = gl.LoadScore(file);
                        gl.LoadGoals(_goals, file);  
                    break;
                    case "5":
                        GoalRecorder gr = new GoalRecorder();
                        Goal selectedGoal = gr.SelectGoal(_goals);
                        gr.RecordGoal(selectedGoal);
                        _score = gr.RecordScore(selectedGoal, _score);
                    break;
                    case "6":
                        GoalDeleter gd = new GoalDeleter();
                        gd.DeleteGoal(_goals);
                        Console.Write("Would you like to save your changes? yes/no ");
                        string deleteSave = Console.ReadLine();
                        switch (deleteSave)
                        {
                            case "yes":
                                GoalSaver dgs = new GoalSaver();
                                dgs.SaveGoal(_goals, _score); 
                            break;
                            case "no":
                                Console.WriteLine("Changes unsaved.");
                            break;
                        }
                    break;
                }
        } while (_menuSelection != "7");    
        Console.WriteLine("Good luck with your goals!\n");
    }
}