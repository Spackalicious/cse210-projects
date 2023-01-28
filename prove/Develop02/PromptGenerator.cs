using System;
using System.IO; 
using System.Collections.Generic;

public class PromptGenerator
{
    // static Random _randomGenerator = new Random();
    // public int _random = _randomGenerator.Next(0,6); 

    
    // Constructor
    public PromptGenerator()
    {        
    }
    
    public string CreatePrompt(int _promptNum)
    {    
        string[] _prompts = 
        { 
            "Who was the most interesting person I interacted with today?"
            , "What was the best part of my day?"
            , "How did I see the hand of the Lord in my life today?"
            , "What was the strongest emotion I felt today?"
            , "If I had one thing I could do over today, what would it be?"
            , "Write your innermost thoughts!" 
            , "You are out of journalling prompts for today! Have at some free journalling."
        };    

        string _promptsGen = _prompts[_promptNum];
        return _promptsGen;        
    }
    public int CreateRandomNumber()
    {
        Random _randomGenerator = new Random();
        int _random = _randomGenerator.Next(0,6);
        return _random;
    }
}