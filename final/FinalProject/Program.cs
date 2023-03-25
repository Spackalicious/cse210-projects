using System;

class Program
{
    static void Main(string[] args)
    {
        string _answer;
        List<Acquaintance> _contactList = new List<Acquaintance>();
        do 
        {
            Console.WriteLine("Hello and welcome to your Contacts Tracker!\n");
            Console.WriteLine("What would you like to do? If you have existing contacts, you must first load them! ");
            // make it so that each option will automatically load / reload contacts, and eliminate option 1.
            // Add a delete contact option? Or add delete to the edit options? 
            // Add history sorting options - like an "Analyze History" with a sub menu. 
            // OR, load contacts and sort history upon opening and present information before the menu?  
            Console.WriteLine("   1. Load Contact History");
            Console.WriteLine("   2. Add Contact");
            Console.WriteLine("   3. Add Event");
            Console.WriteLine("   4. Edit Contact");
            Console.WriteLine("   5. View Contact");
            Console.WriteLine("   6. Quit");
            Console.Write("Please enter your selection: ");
            _answer = Console.ReadLine();
         
        
        switch (_answer)
        {                    
            case "1":
                Console.WriteLine("Loading Contact History");
                ContactLoader contacts = new ContactLoader();
                contacts.LoadContacts(_contactList);
                // contacts.ListContacts();
                // foreach (Acquaintance contact in _contactList)
                // {
                //     Console.WriteLine(contact.GetType());
                //     Console.WriteLine(contact.GetName());
                // }
                Console.WriteLine("\nContact History Loaded!\n");
            break;
            case "2":
            // This needs a menu for what TYPE of contact being created. 
            // Maybe this would be done best in the ContactCreator class? Maybe that's what that class is actually for? 
                Console.WriteLine("Let's add a contact!");
                Acquaintance person = new Acquaintance();
                person.CreatePerson();                
            break;
            case "3":
                Console.WriteLine("Let's add an event!");
                Console.WriteLine("WORK IN PROGRESS :) ");
            break;
            case "4":
                Console.WriteLine("Select a contact to edit: ");
                Console.WriteLine("WORK IN PROGRESS :) ");
            break;
            case "5":
                ContactViewer cv = new ContactViewer();
                cv.ViewContact(_contactList);
            break;
        }        
    } while (_answer != "6");
    Console.WriteLine("Goodbye! Your contacts will miss you!");
    }
}