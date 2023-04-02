using System;

class Program
{
    static void Main(string[] args)
    {
        string _answer;
        do 
        {
            ContactLoader contacts = new ContactLoader();
            List<Acquaintance> _contactList = contacts.LoadContacts();

            Console.WriteLine("\nHello and welcome to your Contacts Tracker!\n");
            Console.WriteLine("What would you like to do? "); 
            Console.WriteLine("   1. View Birthdays");
            Console.WriteLine("   2. Add Contact");
            Console.WriteLine("   3. Add Event");
            Console.WriteLine("   4. Edit Contact");
            Console.WriteLine("   5. View Contact");
            Console.WriteLine("   6. Delete Contact");
            Console.WriteLine("   7. View Christmas Card List");
            Console.WriteLine("   8. View Most Frequently Contacted");
            Console.WriteLine("   9. Quit");
            Console.Write("Please enter your selection: ");
            _answer = Console.ReadLine();        
        
        switch (_answer)
        {                    
            case "1":
                HistorySorter hs = new HistorySorter();
                hs.UpcomingBirthday(_contactList);                             
            break;
            case "2":
            ContactCreator cc = new ContactCreator();
            cc.AddContact();                               
            break;
            case "3":
                Event ee = new Event();
                ee.CreateEvent(_contactList);
            break;
            case "4":
                ContactEditor ce = new ContactEditor();
                ce.EditContact(_contactList);
            break;
            case "5":                
                ContactViewer cv = new ContactViewer();
                cv.ViewContact(_contactList);
            break;
            case "6":              
                ContactDeleter dv = new ContactDeleter();
                dv.DeleteContact(_contactList);
            break;
            case "7":
                HistorySorter chs = new HistorySorter();
                chs.ChristmasCardList(_contactList);
            break;
            case "8":
                HistorySorter fchs = new HistorySorter();
                fchs.FrequentContact();
            break;
        }        
    } while (_answer != "9");
    Console.WriteLine("Goodbye! Your contacts will miss you!\n");
    }
}