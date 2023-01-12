using System;

// Classes to represent a resume or a job history for a person like on LinkedIn
// Wk03 Abstraction Learning Activity

public class Resume
{
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Resume()
    {
    }

    // A method that displays the person's resume with their name, Jobs, and job details. 

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job position in _jobs)
        {
            position.DisplayJobDetails();
        }

    }

    // public void DisplayJobDetails()
    // {
    //     Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    // }
    
}