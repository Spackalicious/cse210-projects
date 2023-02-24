using System;

class ListingActivity : Activity
{ 
    private List<string> _listingPrompts = new List<string> 
    {
        "Who are people that you appreciate?"
        , "What are personal strengths of yours?"
        , "Who are people that you have helped this week?"
        , "When have you felt the Holy Ghost this month?"
        , "Who are some of your personal heroes?"
    };
    
    protected List<string> _listingResponses = new List<string>();
    
    // Constructor
    public ListingActivity() : base()
    {      
        _activityName = "Listing";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }    

    public string GetListingPrompt()
    {
        Random randomGenerator = new Random();
        int reflectingNumber = randomGenerator.Next(0,3);
        return _listingPrompts[reflectingNumber];
    }

   public void DoListing(int duration) 
   {
        // Console.WriteLine("Get Ready!");
        // Spinner(2);
        // Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"---- {GetListingPrompt()}---- \n");
        Console.Write("You may begin in: ");
        Countdown(3);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        int timeLength = duration * 1000;
        DateTime futureTime = startTime.AddSeconds(duration);
        // Thread.Sleep(timeLength);
        DateTime currentTime = DateTime.Now;
        // while (currentTime < futureTime)
        // int i = 0;
          do
          {
               Console.Write("> ");
               string item = Console.ReadLine();
               _listingResponses.Add(item);
               currentTime = DateTime.Now;
          } while (currentTime < futureTime);
            //    i++;
        //   }     while (i < 5);
          Console.WriteLine($"\nYou listed {_listingResponses.Count()} items\n");
        //   Thread.Sleep(8);
        //   Spinner(8);
          ClosingMessage(duration, _activityName);          
   }
}