using System;
using System.Text.RegularExpressions;
public class HistorySorter
{  
    
    public HistorySorter()
    {
    }

    public void ShouldContact()
    {
        // Go through all contact history and find the contact with date of longest time since contact.
        // Given how long this project has already taken me, I'm dropping this portion of it! I'm sorry!  
    }

    public void UpcomingBirthday(List<Acquaintance> contactList)
    {
        List<KeyValuePair<string, string>> bdayList = new List<KeyValuePair<string, string>>();        
        foreach (Acquaintance contact in contactList)
        {
            string personBday = "";
            if (contact.GetBday().Year > 1000)
            {                
                if (contact.GetBday().Month < 10)
                {
                    personBday = $"0{contact.GetBday().Month}-{contact.GetBday().Day}-{contact.GetBday().Year}";
                }
                else
                {
                    personBday = $"{contact.GetBday().Month}-{contact.GetBday().Day}-{contact.GetBday().Year}";
                }   
            bdayList.Add(new KeyValuePair<string, string>(personBday, contact.GetName())); 
            bdayList = bdayList.OrderBy(kvp => kvp.Key).ToList();                                          
            }                  
        }
        Console.WriteLine("\nYour Birthday List: ");        
        foreach (var bday in bdayList)
        {            
            Console.WriteLine(bday);
        }         
    }

    public void FrequentContact()
    {
        List<string> contactEventCounter = new List<string>();
        DirectoryInfo dinfo = new DirectoryInfo(@"contacts");
        FileInfo[] Contacts = dinfo.GetFiles("*.txt");
        foreach( FileInfo contact in Contacts )
        {
            using(StreamReader sr = File.OpenText($"contacts/{contact.Name}"))
            {            
                string s = "";
                while ((s = sr.ReadLine()) != null) 
                    { 
                        string[] parts = s.Split(">>");
                        string[] acquaintanceInfo = parts[0].Split("|");
                        string[] contactHistory = parts[1].Split("::");

                        string mainString = parts[1];
                        string searchString = "::";
                        
                        int eventCount = Regex.Matches(mainString, Regex.Escape(searchString)).Count;

                        string nameCount = $"{eventCount} - {acquaintanceInfo[1]}";
                        contactEventCounter.Add(nameCount);
                    }
            }
        }
        IEnumerable<string> sortedContacts =
        from contact in contactEventCounter
        orderby contact descending
        select contact;
        Console.WriteLine("Your Top 3 most frequently contacted people are: ");
        int w = 0;
        
        foreach (string contact in sortedContacts)
        {
            if (w < 3)
            {
                Console.WriteLine(contact);
                w++;
            }            
        }        
    }

    public void ChristmasCardList(List<Acquaintance> contactList)
    {
        Console.WriteLine("\nYour Christmas Card List: ");
        foreach (Acquaintance contact in contactList)
        {
            if (contact.GetChristmas())
            {                
                Console.WriteLine(contact.GetName());
                Console.WriteLine(contact.GetTheAddress());                              
                Console.WriteLine();                              
            }    
        }
    }
}