using System;
using System.IO; 

// trying to create a class of Prompt

public class Prompt
{
string journal = @"myJournal.txt";   
    static DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString(); 
    static Random randomGenerator = new Random();
    int journalPromptSelector = randomGenerator.Next(1,7);
    string q1 = "Who was the most interesting person I interacted with today?";
    string q2 = "What was the best part of my day?";
    string q3 = "How did I see the hand of the Lord in my life today?";
    string q4 = "What was the strongest emotion I felt today?";
    string q5 = "If I had one thing I could do over today, what would it be?";
    string q6 = "Write your innermost thoughts!";
    string question = "";
    string response = "";

    public Prompt()
    {
    }

        // if (journalPromptSelector == 1) 
        // {  question = q1;  } 
        // else if (journalPromptSelector == 2)
        // {  question = q2;  } 
        // else if (journalPromptSelector == 3)
        // {  question = q3;  } 
        // else if (journalPromptSelector == 4)
        // {  question = q4;  } 
        // else if (journalPromptSelector == 5)
        // {  question = q5;  } 
        // else if (journalPromptSelector == 6)
        // {  question = q6;  } 

    // Console.WriteLine(question);
    // Console.Write("> ");
    // response = Console.ReadLine();

    // using (StreamWriter sw = File.AppendText(journal))
    // {           
    //     sw.Write($"Date: {dateText} - ");     
    //     sw.WriteLine($"Prompt: {question}");
    //     sw.WriteLine(response);
    //     sw.WriteLine();                               
    // }
    
}