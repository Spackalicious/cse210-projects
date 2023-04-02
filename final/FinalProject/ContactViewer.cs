using System;

public class ContactViewer
{  
    string _viewName;
    string _viewRelationship;
    string _relationship;
    DateTime _personBirth = new DateTime(1899, 1, 1);
    int _personBirthYear;
    string _personBday;
    string _personPhone;
    string _personEmail;
    string _PersonAddy;
    string _personChristmas;
    string[] _personHistory;
    List<string> historyList = new List<string>();
    public ContactViewer()
    {
    }

    public void ViewContact(List<Acquaintance> contactList)
    {
        Console.WriteLine("Which subset of your acquaintances would you like to view? ");
        string name = ListContacts(contactList);     
        
        foreach (Acquaintance person in contactList)
        {
            if (String.Equals(name, person.GetName()))
            {
                _relationship = person.GetType().ToString();
                _viewName = person.GetName();
                _viewRelationship = person.GetHint();
                _personBirth = person.GetBday();
                _personBirthYear = _personBirth.Year;
                if (_personBirthYear > 1800)
                {
                    string bdayMonth = _personBirth.ToString("MMMM");
                    int bdayDay = _personBirth.Day;
                     _personBday = $"Birthday: {bdayMonth} {bdayDay}, {_personBirth.Year}";
                }        
                else
                {
                    _personBday = " ";
                }        
                _personPhone = person.GetThePhone();
                _personEmail = person.GetTheEmail();
                _PersonAddy = person.GetTheAddress();

                _personHistory = person.GetHistory().Split("::");
                
                foreach (string item in _personHistory)
                {
                    historyList.Add(item);
                }

                if (person.GetChristmas())
                {
                    _personChristmas = "Make sure to send this person a Christmas card!\n";
                }
                else
                {
                    _personChristmas = "";
                }
            }
        }
                Console.WriteLine($"\nName: {_viewName}");
                Console.WriteLine($"{_relationship}: {_viewRelationship}");
                Console.WriteLine($"{_personBday}");             
                Console.WriteLine($"Phone: {_personPhone}");
                Console.WriteLine($"Email: {_personEmail}");
                Console.WriteLine($"Address: {_PersonAddy}");
                Console.WriteLine($"{_personChristmas}");        
                Console.WriteLine($"Your History with {_viewName}:");    
                foreach (string item in historyList)
                {
                    Console.WriteLine($"{item}");
                }    
    }
    
    public string ListContacts(List<Acquaintance> contactList)
    {
        Console.WriteLine("   1. Acquaintances");
        Console.WriteLine("   2. Family");
        Console.WriteLine("   3. Friends");
        Console.WriteLine("   4. Neighbors");
        Console.WriteLine("   5. Coworkers");
        Console.WriteLine("   6. All");
        Console.Write("Please enter your selection: ");
        List<string> nameList = new List<string>();
        string nameSelection = " ";
        int listAnswer = int.Parse(Console.ReadLine());
        int i = 1;
        int numNameSelect;
        switch (listAnswer)
        {
            case 1: 
                Console.WriteLine("Acquaintances:");
                foreach (Acquaintance acquaintance in contactList)
                {                    
                    if (String.Equals(acquaintance.GetType().ToString(), "Acquaintance"))
                    {                
                        Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                        nameList.Add(acquaintance.GetName());
                        i++;
                    }
                } 
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];
            break;
            case 2: 
                Console.WriteLine("Family:");
                foreach (Acquaintance acquaintance in contactList)
                {                    
                    if (String.Equals(acquaintance.GetType().ToString(), "Family"))
                    {                
                        Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                        nameList.Add(acquaintance.GetName());
                        i++;
                    }
                }  
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];              
            break;
            case 3: 
                Console.WriteLine("Friends:");
                foreach (Acquaintance acquaintance in contactList)
                {                    
                    if (String.Equals(acquaintance.GetType().ToString(), "Friend"))
                    {                
                        Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                        nameList.Add(acquaintance.GetName());
                        i++;
                    }
                }     
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];           
            break;
            case 4: 
                Console.WriteLine("Neighbors:");
                foreach (Acquaintance acquaintance in contactList)
                {                    
                    if (String.Equals(acquaintance.GetType().ToString(), "Neighbor"))
                    {                
                        Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                        nameList.Add(acquaintance.GetName());
                        i++;
                    }
                }       
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];         
            break;
            case 5: 
                Console.WriteLine("Coworkers:");
                foreach (Acquaintance acquaintance in contactList)
                {                    
                    if (String.Equals(acquaintance.GetType().ToString(), "Coworker"))
                    {                
                        Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                        nameList.Add(acquaintance.GetName());
                        i++;
                    }
                }       
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];         
            break;
            case 6: 
                Console.WriteLine("All Contacts:");
                foreach (Acquaintance acquaintance in contactList)
                {                                  
                    Console.WriteLine($"   {i}. {acquaintance.GetName()}");
                    nameList.Add(acquaintance.GetName());
                    i++;
                }   
                Console.Write("Please enter your selection: ");
                numNameSelect = int.Parse(Console.ReadLine());           
                nameSelection = nameList[numNameSelect - 1];             
            break;
        }
        return nameSelection;
    }
}