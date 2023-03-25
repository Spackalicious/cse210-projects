using System;

public class ContactDeleter
{  
    
    public ContactDeleter()
    {
    }

    public void DeleteContact(List<Acquaintance> contactList)
    {
        ContactViewer dcv = new ContactViewer();
        dcv.ListContacts();

        // pick from the list and then delete the text file. 
        // Reload Contact List
    }
}