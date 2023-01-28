using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        // user response from main menu
        string answer;
        // control list so prompts do not get reused within a session.
        List<int> usedInts = new List<int>();
        // List of entries from current session
        List<string> sessionEntries = new List<string>();
        do 
        {
            string[] _menuItems = 
            { "1. Write a new entry"
            , "2. Display today's entries"
            , "3. Load the journal from file"
            , "4. Save journal to a file"
            , "5. Delete last entry"
            , "6. Quit" };
            
            Console.WriteLine("What would you like to do?");
            foreach (string item in _menuItems)
            {
                Console.WriteLine(item);
            }
            Console.Write("Please select 1, 2, 3, 4, 5, or 6. ");
            answer = Console.ReadLine();

            if (answer == "1")
            {                
                // This prevents prompts from being reused within the same session
                PromptGenerator newPrompt = new PromptGenerator();                    
                    if (usedInts.Count() < 6)
                    {
                        int randomNumber = newPrompt.CreateRandomNumber();
                        bool isElementPresent = usedInts.Contains(randomNumber);
                        if (!isElementPresent) 
                        {
                            usedInts.Add(randomNumber);
                            Entry newEntry = new Entry();
                            newEntry.createEntry(randomNumber, sessionEntries);
                        } 
                        else if (usedInts.Contains(randomNumber))
                        {
                            do {
                            randomNumber = newPrompt.CreateRandomNumber();
                            } while (usedInts.Contains(randomNumber));
                            usedInts.Add(randomNumber);
                            Entry newEntry = new Entry();
                            newEntry.createEntry(randomNumber, sessionEntries);
                        }
                    }
                    else{
                        Entry newEntry = new Entry();
                        newEntry.createEntry(6, sessionEntries);
                    }
                                                            
                // Console.WriteLine($"There are {usedInts.Count()} prompts used.");
                // Console.WriteLine("These are the random prompt numbers used!");
                // foreach (int integer in usedInts)
                // {
                //     Console.Write(integer + " ");
                // }
                // Console.WriteLine(' ');               
            }
            if (answer == "2")
            {
                Entry newEntry = new Entry();
                newEntry.Display(sessionEntries);
            }
            if (answer == "3")
            {                
                Journal newJournal = new Journal();
                newJournal.displayJournal();
            }
            if (answer == "4") 
            {
                Journal newJournal = new Journal();
                newJournal.appendEntries(sessionEntries);
            }
            if (answer == "5")
            {
                Journal newJournal = new Journal();
                newJournal.DeleteLastEntry();
            }

            if (answer == "6") 
            {
                Console.WriteLine($"Goodbye. \n");
            }
        } while (answer != "6");        
        
    }
}