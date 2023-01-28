using System;

class Journal
{
    // Constructor
    public Journal()
    {        
    }

    public void displayJournal()
    {
        Console.WriteLine("What is your journal file called?");
        string _journalName = Console.ReadLine();
        Console.WriteLine($"Now displaying {_journalName} \n");
        string _filename = $"{_journalName}.txt";
            // string[] lines = System.IO.File.ReadAllLines(_filename);
            using(StreamReader sr = File.OpenText(_filename))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null) {
                    Console.WriteLine(s);
                }
            } 
    }
    public List<string> appendEntries(List<string> _sessionEntries)
    {
        Console.WriteLine("Where would you like to save your journal?");
        string _journalName = Console.ReadLine();
        string _journal = $@"{_journalName}.txt";
        using (StreamWriter sw = File.AppendText(_journal))
        {                     
            foreach (string _entry in _sessionEntries)
            {
                sw.Write(_entry); 
            }                                           
        }
        Console.WriteLine($"Entries saved to {_journalName}.txt \n"); 
        // Once session entries has been appended to journal, session entries list should be emptied
        _sessionEntries.Clear();
        return _sessionEntries;
    }
    public void DeleteLastEntry()
    {
        Console.WriteLine("Which journal file's last entry would you like to delete?");
        string _journalName = Console.ReadLine();
        string _filepath = $@"{_journalName}.txt";
        // string _filepath = "myJournal.txt";
        List<string> lines = File.ReadAllLines(_filepath).ToList();

    if (lines.Count > 3)
    {
        File.WriteAllLines(_filepath, lines.GetRange(0, lines.Count - 4).ToArray());
        Console.WriteLine($"Last entry deleted \n");
    }
    else {
        Console.WriteLine($"Journal is empty \n");
    }
    }
}