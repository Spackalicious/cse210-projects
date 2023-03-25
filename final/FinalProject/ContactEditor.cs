using System;

public class ContactEditor
{  
    
    public ContactEditor()
    {
    }

    public void EditContact(List<Acquaintance> contactList)
    {
        ContactViewer dcv = new ContactViewer();
        dcv.ListContacts();

        // pick a contact from the list to edit. 
        // give the user a menu of editing options
        // select from the list of what to edit.
    }
}