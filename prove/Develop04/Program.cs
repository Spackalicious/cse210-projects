using System;

class Program
{    
    static void Main()
    {
        string _answer = " ";
        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Start nature activity");
            Console.WriteLine(" 5. Start stretching activity");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            _answer = Console.ReadLine();

            switch (_answer)
                {                    
                    case "1":
                        BreathingActivity breathe1 = new BreathingActivity();
                        int durationBreathe = breathe1.StartingMessage();   
                        breathe1.DoBreathing(durationBreathe);                              
                    break;  
                    case "2":
                        ReflectingActivity reflect1 = new ReflectingActivity();   
                        int durationReflect = reflect1.StartingMessage();
                        reflect1.DoReflecting(durationReflect);                        
                    break;  
                    case "3":
                        ListingActivity list1 = new ListingActivity();   
                        int durationList = list1.StartingMessage();
                        list1.DoListing(durationList);                               
                    break;  
                    case "4":
                        NatureActivity nature1 = new NatureActivity(); 
                        int durationNature = nature1.StartingMessage();
                        nature1.DoNature(durationNature);
                    break;
                    case "5":
                        StretchingActivity stretch1 = new StretchingActivity(); 
                        int durationStretch = stretch1.StartingMessage();
                        stretch1.DoStretching(durationStretch);
                    break;
                }
        } while (_answer != "6");    
        Console.WriteLine("Goodbye.\n");
    }
}