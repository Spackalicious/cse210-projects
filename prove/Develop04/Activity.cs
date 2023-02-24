using System;

class Activity
{
    protected string _activityName = " ";
    protected string _activityDescription = " ";
    
    // Constructor
    public Activity()
    {      
    }  
    
    // Constructor
    public Activity(string activityName, string activityDescription)
    {   
        _activityName = activityName;
        _activityDescription = activityDescription;
    }      

    public int StartingMessage()
    {
        Console.Clear();
        string startmessage = $"Welcome to the {_activityName} Activity. \n\n{_activityDescription} \n\nHow long, in seconds, would you like for your session? ";
        Console.Write(startmessage);
        int duration = int.Parse(Console.ReadLine());
        // Console.WriteLine();
        
        Console.Clear();
        Console.WriteLine("Get Ready...\n");
        Spinner(3);
        Console.Clear();
        return duration;
    }

    public void Spinner(int time) 
   {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("—"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            currentTime = DateTime.Now;
        } 
   }
    public void Countdown(int startNumber) 
    {
        while (startNumber > 0)
        {
            Console.Write(startNumber);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            startNumber--;            
        }
   } 
    
    public void ClosingMessage(int duration, string name)
    {
        string m = $"Well done!! \n\nYou have completed {duration} seconds of the {name} Activity.\n";
        Console.WriteLine(m);
        Spinner(4);
    }
     
}