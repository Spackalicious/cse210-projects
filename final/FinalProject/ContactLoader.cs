using System;

public class ContactLoader
{  
    
    public ContactLoader()
    {
    }

    public List<Acquaintance> LoadContacts()
    {
        List<Acquaintance> contactList = new List<Acquaintance>();
        // DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\Julie\Documents\BYU-I\2023-01\CSE210\cse210-projects\final\FinalProject\contacts");
        DirectoryInfo dinfo = new DirectoryInfo(@"contacts");
        FileInfo[] Contacts = dinfo.GetFiles("*.txt");
        foreach( FileInfo contact in Contacts )
        {
            // string filename = $"{contact}";
            using(StreamReader sr = File.OpenText($"contacts/{contact.Name}"))
            {            
                // sr.ReadLine();
                string s = "";
                while ((s = sr.ReadLine()) != null) 
                    { 
                        // Console.WriteLine(s);
                        string[] parts = s.Split(">>");
                        string[] acquaintanceInfo = parts[0].Split("|");
                        string contactHistory = parts[1];
                        // string[] eventDetails = contactHistory[].Split(" - ");
                        string contactType = acquaintanceInfo[0];

                        Contact contactLoading = new Contact(acquaintanceInfo[5], acquaintanceInfo[6], acquaintanceInfo[7]);

                        if (String.Equals(contactType, "Acquaintance"))
                        {                
                            Acquaintance contactAcquaintance = new Acquaintance(acquaintanceInfo[1], DateTime.Parse(acquaintanceInfo[2]), acquaintanceInfo[3], bool.Parse(acquaintanceInfo[4]), contactLoading, contactHistory);
                            contactList.Add(contactAcquaintance);
                        }
                        else if (String.Equals(contactType, "Family"))
                        {
                            Acquaintance contactFamily = new Family(acquaintanceInfo[1], DateTime.Parse(acquaintanceInfo[2]), acquaintanceInfo[3], bool.Parse(acquaintanceInfo[4]), contactLoading, contactHistory);
                            contactList.Add(contactFamily);
                        }
                        else if (String.Equals(contactType, "Friend"))
                        {
                            Acquaintance contactFriend = new Friend(acquaintanceInfo[1], DateTime.Parse(acquaintanceInfo[2]), acquaintanceInfo[3], bool.Parse(acquaintanceInfo[4]), contactLoading, contactHistory);
                            contactList.Add(contactFriend);      
                        }
                        else if (String.Equals(contactType, "Neighbor"))
                        {
                            Acquaintance contactNeighbor = new Neighbor(acquaintanceInfo[1], DateTime.Parse(acquaintanceInfo[2]), acquaintanceInfo[3], bool.Parse(acquaintanceInfo[4]), contactLoading, contactHistory);
                            contactList.Add(contactNeighbor);      
                        } 
                        else if (String.Equals(contactType, "Coworker"))
                        {
                            Acquaintance contactCoworker = new Coworker(acquaintanceInfo[1], DateTime.Parse(acquaintanceInfo[2]), acquaintanceInfo[3], bool.Parse(acquaintanceInfo[4]), contactLoading, contactHistory);
                            contactList.Add(contactCoworker);      
                        } 
                    }
            } 
        }
        return contactList; 
    }    
}