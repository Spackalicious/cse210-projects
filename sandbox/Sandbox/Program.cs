using System;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        string answer;    
        do 
        {
        Console.WriteLine("Hello Everyone in the Sandbox World!");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load the journal from file");
        Console.WriteLine("4. Save journal to a file");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? Please select 1, 2, 3, 4, or 5. ");
        answer = Console.ReadLine();

        if (answer == "1") 
        {
            // Prompt prompt = new Prompt();
            // WriteJournal entry = new WriteJournal();
            // WriteJournal();

        string journal = @"myJournal.txt";   
         DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString(); 
        Random randomGenerator = new Random();
        int journalPromptSelector = randomGenerator.Next(1,7);
        string q1 = "Who was the most interesting person I interacted with today?";
        string q2 = "What was the best part of my day?";
        string q3 = "How did I see the hand of the Lord in my life today?";
        string q4 = "What was the strongest emotion I felt today?";
        string q5 = "If I had one thing I could do over today, what would it be?";
        string q6 = "Write your innermost thoughts!";
        string question = "";
        string response = "";

        if (journalPromptSelector == 1) 
        {  question = q1;  } 
        else if (journalPromptSelector == 2)
        {  question = q2;  } 
        else if (journalPromptSelector == 3)
        {  question = q3;  } 
        else if (journalPromptSelector == 4)
        {  question = q4;  } 
        else if (journalPromptSelector == 5)
        {  question = q5;  } 
        else if (journalPromptSelector == 6)
        {  question = q6;  } 

        Console.WriteLine(question);
        Console.Write("> ");
        response = Console.ReadLine();

        using (StreamWriter sw = File.AppendText(journal))
        {           
            sw.Write($"Date: {dateText} - ");     
            sw.WriteLine($"Prompt: {question}");
            sw.WriteLine(response);
            sw.WriteLine();                               
        }

        } 
        if (answer == "2") {
            string filename = "myJournal.txt";
            // string[] lines = System.IO.File.ReadAllLines(filename);
            using(StreamReader sr = File.OpenText(filename))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null) {
                    Console.WriteLine(s);
                }
            }            
        } 
        }  while (answer != "5");
    } 
}
    
    
 
        
  
        

