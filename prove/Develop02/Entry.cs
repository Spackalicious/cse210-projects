using System;
using System.Collections.Generic;

class Entry
{
    static DateTime theCurrentTime = DateTime.Now;
    static string _date = theCurrentTime.ToShortDateString();
    static string _response = "";
    static string _author = "";

    
    
    // Constructor
    public Entry()
    {        
    }

    public List<string> createEntry(int promptNum, List<string> sessionEntries)
    {
        PromptGenerator newPrompt = new PromptGenerator();
        string _prompt = newPrompt.CreatePrompt(promptNum);
        
        Console.WriteLine("Create a new Entry");
        // Console.Write($"Date: {_date} - ");        
        Console.WriteLine($"Prompt: {_prompt} - ");
        Console.Write("> ");
        _response = Console.ReadLine();
        Console.Write("by (author): ");
        _author = Console.ReadLine();

        string entry = ($"Date: {_date} - Prompt: {_prompt} \n {_response} \n {_author} \n\n");
        sessionEntries.Add(entry);
        return sessionEntries;

        // string journal = @"myJournal.txt";
        // using (StreamWriter sw = File.AppendText(journal))
        // {           
        //     sw.Write($"Date: {_date} - ");     
        //     sw.WriteLine($"Prompt: {_prompt}");
        //     sw.WriteLine(_response);
        //     sw.WriteLine($"by: {_author}");
        //     sw.WriteLine();                               
        // }
    }
    public void Display(List<string> sessionEntries)
    {
        Console.WriteLine($"Today's journal entries (unsaved) \n");
        foreach (string entry in sessionEntries)
        {
            Console.WriteLine(entry);
        }
    }
}