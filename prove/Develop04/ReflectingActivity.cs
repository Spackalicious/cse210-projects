using System;

class ReflectingActivity : Activity
{ 
    List<string> _reflectingPrompts = new List<string> 
    {
        "Think of a time when you stood up for someone else."
        , "Think of a time when you did something really difficult."
        , "Think of a time when you helped someone in need."
        , "Think of a time when you did something truly selfless."
    };
    List<string> _reflectingQuestions = new List<string>
    {
        "Why was this experience meaningful to you?"
        , "Have you ever done anything like this before?"
        , "How did you get started?"
        , "How did you feel when it was complete?"
        , "What made this time different than other times when you were not as successful?"
        , "What is your favorite thing about this experience?"
        , "What could you learn from this experience that applies to other situations?"
        , "What did you learn about yourself through this experience?"
        , "How can you keep this experience in mind in the future?"
    };
    // Constructor
    public ReflectingActivity() : base()
    {      
        _activityName = "Reflecting";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }    

    public string GetReflectingPrompt()
    {
        Random randomGenerator = new Random();
        int reflectingNumber = randomGenerator.Next(0,3);
        return _reflectingPrompts[reflectingNumber];
    }

    public int GetReflectingQuestion()
    {
        Random randomGenerator = new Random();
        int reflectingNumber = randomGenerator.Next(0,8);
        // return _reflectingQuestions[reflectingNumber];
        return reflectingNumber;
    }
   public void DoReflecting(int duration) 
   {   
        List<int> questionNumbers = new List<int> ();   
        // Console.Clear();
        // Console.WriteLine("Get Ready...");
        // Spinner(2);
        Console.WriteLine($" --- {GetReflectingPrompt()} ---  \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("Begin in: ");
        Countdown(3);          
        Console.Clear();
        int s = 0;                  
        do
        {
            int questionNumber = GetReflectingQuestion();
            if (!questionNumbers.Contains(questionNumber) )
            {
                questionNumbers.Add(questionNumber);
                Console.Write($"> {_reflectingQuestions[questionNumber]}  ");
                Spinner(8);
                Console.WriteLine("\n");
                s += 8;
            }
        } while(s < duration);      
        ClosingMessage(duration, _activityName);
   }
}