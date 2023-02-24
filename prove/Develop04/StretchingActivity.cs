using System;

class StretchingActivity : Activity
{ 
    List<string> _stretchingPrompts = new List<string> 
    {
        "Stretch your arms high above your head!"
        , "Curl your toes under your desk and hold them tight!"
        , "Feel yourself relaxing from the top of your head, down to your fingertips and the ends of your toes."
        , "Get up from your desk and hop up and down until your time is done!"
        , "Stand up with your arms straight out and twirl your arms into circles, forward and backward."
        , "Just for kicks, rub your belly and pat your head for the duration."
        , "Carefully let your head fall forward, and then roll it gently from side to side."
    };
    
    // Constructor
    public StretchingActivity() : base()
    {      
        _activityName = "Stretching";
        _activityDescription = "Sometimes we sit at our desks for too long. This will help you remember to get moving, just a little!";
    }    

    public string GetStretchingPrompt()
    {
        Random randomGenerator = new Random();
        int stretchNumber = randomGenerator.Next(0,6);
        return _stretchingPrompts[stretchNumber];
    }

   public void DoStretching(int duration) 
   {   
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {         
            Console.Write($"\n\n--- {GetStretchingPrompt()} ---\n\n\n\n");
            Spinner(duration);
            Console.WriteLine("\n");
            currentTime = DateTime.Now;
        }     
        ClosingMessage(duration, _activityName);
   }
}