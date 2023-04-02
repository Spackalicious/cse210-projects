using System;

public class ContactDeleter
{  
    public ContactDeleter()
    {
    }

    public void DeleteContact(List<Acquaintance> contactList)
    {
        Console.WriteLine("Which subset of your acquaintances would you like to delete from? ");
        ContactViewer dcv = new ContactViewer();
        string deleteName = dcv.ListContacts(contactList);

        Console.Write($"You've chosen to delete {deleteName}. Are you sure? (yes/no) ");
        string deleteReply = Console.ReadLine();
        if (deleteReply == "yes")
        {
            string deleteFileName = $"{deleteName}.txt";
            string rootFolder = @"contacts";
            File.Delete(Path.Combine(rootFolder, deleteFileName));
            Console.WriteLine($"Contact {deleteName} deleted successfully.");
        }
    }
    public void DeleteContact(string dname)
    {
        string deleteFileName = $"{dname}.txt";
        string rootFolder = @"contacts";
        File.Delete(Path.Combine(rootFolder, deleteFileName));
    }
}