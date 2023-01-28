using System;
using System.Collections.Generic;

class Entry
{
    static DateTime _theCurrentTime = DateTime.Now;
    static string _date = _theCurrentTime.ToShortDateString();
    static string _response = "";
    static string _author = "";

    
    
    // Constructor
    public Entry()
    {        
    }

    public List<string> createEntry(int _promptNum, List<string> _sessionEntries)
    {
        PromptGenerator _newPrompt = new PromptGenerator();
        string _prompt = _newPrompt.CreatePrompt(_promptNum);
        
        Console.WriteLine("Create a new Entry");
        // Console.Write($"Date: {_date} - ");        
        Console.WriteLine($"Prompt: {_prompt} - ");
        Console.Write("> ");
        _response = Console.ReadLine();
        Console.Write("by (author): ");
        _author = Console.ReadLine();

        string _entry = ($"Date: {_date} - Prompt: {_prompt} \n {_response} \n {_author} \n\n");
        _sessionEntries.Add(_entry);
        return _sessionEntries;

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
    public void Display(List<string> _sessionEntries)
    {
        Console.WriteLine($"Today's journal entries (unsaved) \n");
        foreach (string _entry in _sessionEntries)
        {
            Console.WriteLine(_entry);
        }
    }
}