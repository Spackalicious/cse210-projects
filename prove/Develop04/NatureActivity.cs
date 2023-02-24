using System;

class NatureActivity : Activity
{ 
    List<string> _naturePrompts = new List<string> 
    {
        "Picture a blue sky full of wispy white clouds strolling lazily by... "
        , "Imagine a forest full of green shadows and cute, happy animals... "
        , "Envision a field full of flowers in your favorite colors, all waving gently in the breeze..."
        , "How do you feel when you're outside, and the sun is gently warming your face, and there is a soft wind?"
        , "Place yourself in a scene with a waterfall. You can hear the water rushing down. There are birds chirping. You are at peace..."
        , "Pretend that you are walking outside in the warm rain, enjoying the fresh water as it cleans everything around you..."
        , "Visualize a beach with sparkling grains of sand, foaming waves, and seagulls shrieking in the wind..."
    };
    
    // Constructor
    public NatureActivity() : base()
    {      
        _activityName = "Nature";
        _activityDescription = "This activity will help you achieve balance and positivity by focusing on nature.";
    }    

    public int GetNaturePrompt()
    {
        Random randomGenerator = new Random();
        int natureNumber = randomGenerator.Next(0,6);
        return natureNumber;
    }

   public void DoNature(int duration) 
   {   
        List<int> natureNumbers = new List<int> ();   
        int s = 0;                  
        do
        {
            int natureNumber = GetNaturePrompt();
            if (!natureNumbers.Contains(natureNumber) )
            {
                natureNumbers.Add(natureNumber);
                Console.Write($"> {_naturePrompts[natureNumber]}  ");
                Spinner(5);
                Console.WriteLine("\n");
                s += 5;
            }
        } while(s < duration);      
        ClosingMessage(duration, _activityName);
   }
}