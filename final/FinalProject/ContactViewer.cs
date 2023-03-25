using System;

public class ContactViewer
{  
    string _viewName;
    string _viewRelationship;
    DateTime _personBirth;
    int _personBirthYear;
    string _personBday;
    string _personPhone;
    string _personEmail;
    string _PersonAddy;
    string _personChristmas;
    public ContactViewer()
    {
    }

    public void ViewContact(List<Acquaintance> contactList)
    {
        List<string> cvContactList = ListContacts();
        Console.Write("Which of your contacts would you like to view? ");
        int selection = int.Parse(Console.ReadLine());
        string name = cvContactList[selection-1];
        // Console.WriteLine($"You've chosen to view {name}");

        ContactLoader cvContacts = new ContactLoader();
        List<Acquaintance> people = cvContacts.LoadContacts(contactList);
        
        
        foreach (Acquaintance person in people)
        {
            if (String.Equals(name, person.GetName()))
            {
                _viewName = person.GetName();
                _viewRelationship = person.GetHint();
                DateTime _personBirth = person.GetBday();
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
                Console.WriteLine($"Relationship: {_viewRelationship}");
                Console.WriteLine($"{_personBday}");             
                Console.WriteLine($"Phone: {_personPhone}");
                Console.WriteLine($"Email: {_personEmail}");
                Console.WriteLine($"Address: {_PersonAddy}");
                Console.WriteLine($"{_personChristmas}\n");        
    }
    
    public List<string> ListContacts()
    {
        DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\Julie\Documents\BYU-I\2023-01\CSE210\cse210-projects\final\FinalProject\contacts");
        FileInfo[] Contacts = dinfo.GetFiles("*.txt");
        int i = 1;
        List<string> contactList = new List<string>();
        foreach( FileInfo contact in Contacts )
        {
            string contactName = contact.Name.TrimEnd('.','t','x','t');
            Console.Write($"{i}. ");
            Console.WriteLine(contactName);
            i++;
            contactList.Add(contactName);
        }     
        return contactList;   
    }
}