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
        string journalName = Console.ReadLine();
        Console.WriteLine($"Now displaying {journalName} \n");
        string filename = $"{journalName}.txt";
            // string[] lines = System.IO.File.ReadAllLines(filename);
            using(StreamReader sr = File.OpenText(filename))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null) {
                    Console.WriteLine(s);
                }
            } 
    }
    public List<string> appendEntries(List<string> sessionEntries)
    {
        Console.WriteLine("Where would you like to save your journal?");
        string journalName = Console.ReadLine();
        string journal = $@"{journalName}.txt";
        using (StreamWriter sw = File.AppendText(journal))
        {                     
            foreach (string entry in sessionEntries)
            {
                sw.Write(entry); 
            }                                           
        }
        Console.WriteLine($"Entries saved to {journalName}.txt \n"); 
        // Once session entries has been appended to journal, session entries list should be emptied
        sessionEntries.Clear();
        return sessionEntries;
    }
    public void DeleteLastEntry()
    {
    Console.WriteLine("Which journal file's last entry would you like to delete?");
    string journalName = Console.ReadLine();
    string filepath = $@"{journalName}.txt";
    // string filepath = "myJournal.txt";
    List<string> lines = File.ReadAllLines(filepath).ToList();

    if (lines.Count > 3)
    {
        File.WriteAllLines(filepath, lines.GetRange(0, lines.Count - 4).ToArray());
        Console.WriteLine($"Last entry deleted \n");
    }
    else {
        Console.WriteLine($"Journal is empty \n");
    }
    }
}