using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        // user response from main menu
        string _answer;
        // control list so prompts do not get reused within a session.
        List<int> _usedInts = new List<int>();
        // List of entries from current session
        List<string> _sessionEntries = new List<string>();
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
            _answer = Console.ReadLine();

            if (_answer == "1")
            {                
                // This prevents prompts from being reused within the same session
                PromptGenerator _newPrompt = new PromptGenerator();                    
                    if (_usedInts.Count() < 6)
                    {
                        int _randomNumber = _newPrompt.CreateRandomNumber();
                        bool isElementPresent = _usedInts.Contains(_randomNumber);
                        if (!isElementPresent) 
                        {
                            _usedInts.Add(_randomNumber);
                            Entry _newEntry = new Entry();
                            _newEntry.createEntry(_randomNumber, _sessionEntries);
                        } 
                        else if (_usedInts.Contains(_randomNumber))
                        {
                            do {
                            _randomNumber = _newPrompt.CreateRandomNumber();
                            } while (_usedInts.Contains(_randomNumber));
                            _usedInts.Add(_randomNumber);
                            Entry _newEntry = new Entry();
                            _newEntry.createEntry(_randomNumber, _sessionEntries);
                        }
                    }
                    else{
                        Entry _newEntry = new Entry();
                        _newEntry.createEntry(6, _sessionEntries);
                    }
                                                            
                // Console.WriteLine($"There are {_usedInts.Count()} prompts used.");
                // Console.WriteLine("These are the random prompt numbers used!");
                // foreach (int integer in _usedInts)
                // {
                //     Console.Write(integer + " ");
                // }
                // Console.WriteLine(' ');               
            }
            if (_answer == "2")
            {
                Entry _newEntry = new Entry();
                _newEntry.Display(_sessionEntries);
            }
            if (_answer == "3")
            {                
                Journal _newJournal = new Journal();
                _newJournal.displayJournal();
            }
            if (_answer == "4") 
            {
                Journal _newJournal = new Journal();
                _newJournal.appendEntries(_sessionEntries);
            }
            if (_answer == "5")
            {
                Journal _newJournal = new Journal();
                _newJournal.DeleteLastEntry();
            }

            if (_answer == "6") 
            {
                Console.WriteLine($"Goodbye. \n");
            }
        } while (_answer != "6");        
        
    }
}