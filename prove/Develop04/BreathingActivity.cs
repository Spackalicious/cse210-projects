using System;

class BreathingActivity : Activity
{ 
    // Constructor
    public BreathingActivity() : base()
    {      
        _activityName = "Breathing";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }    

   public void DoBreathing(int duration) 
   {
        //   Console.Clear();
        //   Console.WriteLine("Get Ready!\n");
        //   Spinner(2);
        //   int s = 0;

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(duration);
            DateTime currentTime = DateTime.Now;
            while (currentTime < futureTime)

        //   while(s < duration)
          {
               Console.Write("Breathe in...  ");
               Countdown(3);
               Console.WriteLine("\n");
            //    s += 3;
               Console.Write("Breathe out...  ");
               Countdown(3);
               Console.WriteLine("\n");
            //    s += 3;
            currentTime = DateTime.Now;
          } 
          ClosingMessage(duration, _activityName);
   }
}