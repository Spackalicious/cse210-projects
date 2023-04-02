using System;

public class Event
{  
    private DateOnly _eventDate = DateOnly.FromDateTime(DateTime.Now);
    private string _eventDetails;
    public Event()
    {
    }

    public void CreateEvent(List<Acquaintance> contactList)
    {
        Console.WriteLine("Which subset of your acquaintances did you interact with? ");
        ContactViewer ecv = new ContactViewer();
        string eventsName = ecv.ListContacts(contactList);

        Console.WriteLine($"You've interacted with {eventsName}. When?");
        Console.Write($"Type either 'today', or a date (mm/dd/yyyy) ");
        string eventReplyDate = Console.ReadLine();
        if (eventReplyDate == "today")
        {
            _eventDate = DateOnly.FromDateTime(DateTime.Now);
        }
        else
        {
            _eventDate = DateOnly.Parse(eventReplyDate);
        }

        Console.WriteLine($"What did you do with {eventsName}?");
        _eventDetails = Console.ReadLine();

        // append event to existing contact file
        string contactFile = $@"contacts\{eventsName}.txt";
        using (StreamWriter sw = File.AppendText(contactFile))
        {                           
            sw.Write($"{_eventDate} - ");                                                               
            sw.Write($"{_eventDetails}::");                                  
        }
        Console.WriteLine($"Event saved to {eventsName}.txt \n");
    }
}