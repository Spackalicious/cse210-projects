using System;

public class ContactEditor
{  
    
    public ContactEditor()
    {
    }

    public void EditContact(List<Acquaintance> contactList)
    {
        ContactCreator cecc = new ContactCreator();
        ContactDeleter cecd = new ContactDeleter();
        Console.WriteLine("From which subset of your acquaintances would you like to edit? ");
        ContactViewer ecv = new ContactViewer();
        string editName = ecv.ListContacts(contactList);
        Console.WriteLine($"You've chosen to edit {editName}.");
       
        Console.WriteLine($"Which portion of {editName} would you like to edit?");

        Console.WriteLine($"   1. Type");
        Console.WriteLine($"   2. Name");
        Console.WriteLine($"   3. Birthday");
        Console.WriteLine($"   4. Hint");
        Console.WriteLine($"   5. Christmas Card");
        Console.WriteLine($"   6. Phone");
        Console.WriteLine($"   7. Email");
        Console.WriteLine($"   8. Address");
        Console.Write("Please enter your selection: ");
        int editAnswer = int.Parse(Console.ReadLine());
        

        switch (editAnswer)
        {
            case 1:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {
                        Contact keepContact = new Contact(person.GetThePhone(), person.GetTheEmail(), person.GetTheAddress());
                        Console.WriteLine("What type of contact should this be? ");
                        Console.WriteLine($"   1. Acquaintance");
                        Console.WriteLine($"   2. Family");
                        Console.WriteLine($"   3. Friend");
                        Console.WriteLine($"   4. Neighbor");
                        Console.WriteLine($"   5. Coworker");
                        Console.Write("Please enter your selection: ");
                        int editType = int.Parse(Console.ReadLine());
                        switch (editType)
                        {
                            case 1:                              
                                Acquaintance typeAcquaintance = new Acquaintance(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                                cecc.SaveContact(editName, typeAcquaintance);
                            break;
                            case 2:
                                Acquaintance typeFamily = new Family(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                                cecc.SaveContact(editName, typeFamily);
                            break;
                            case 3:
                                Acquaintance typeFriend = new Friend(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                                cecc.SaveContact(editName, typeFriend);
                            break;
                            case 4: 
                                Acquaintance typeNeighbor = new Neighbor(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                                cecc.SaveContact(editName, typeNeighbor);
                            break;
                            case 5:
                                Acquaintance typeCoworker = new Coworker(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                                cecc.SaveContact(editName, typeCoworker);
                            break;
                        }
                    }
                }
            break;
            case 2:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {
                        Contact keepContact = new Contact(person.GetThePhone(), person.GetTheEmail(), person.GetTheAddress());
                        Console.Write($"What would you like to change {editName}'s name to? ");
                        string newName = Console.ReadLine();
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(newName, person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(newName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(newName, person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(newName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(newName, person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(newName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(newName, person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(newName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(newName, person.GetBday(), person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(newName, editedName);
                        }                        
                        cecd.DeleteContact(editName);
                        Console.WriteLine($"{editName} successfully updated to {newName}");
                    }
                }
            break;
            case 3:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {
                        Contact keepContact = new Contact(person.GetThePhone(), person.GetTheEmail(), person.GetTheAddress());
                        Console.WriteLine($"What would you like to change {editName}'s birthday to? (mm/dd/yyyy) ");
                        Console.Write($"**If you do not know the birth year, please enter (mm/dd/1900) ");
                        DateTime newBday = DateTime.Parse(Console.ReadLine());
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(person.GetName(), newBday, person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(person.GetName(), newBday, person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(person.GetName(), newBday, person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(person.GetName(), newBday, person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(person.GetName(), newBday, person.GetHint(), person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        } 
                        string newStringBday = $"Birthday: {newBday.ToString("MMMM")} {newBday.Day}, {newBday.Year}";                       
                        Console.WriteLine($"{editName}'s birthday successfully updated to {newStringBday}");
                    }
                }
            break;
            case 4:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {
                        Contact keepContact = new Contact(person.GetThePhone(), person.GetTheEmail(), person.GetTheAddress());
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Console.WriteLine($"What would you like to change {editName}'s hint to? ");
                            string newHint = Console.ReadLine();
                            Acquaintance editedName = new Acquaintance(person.GetName(), person.GetBday(), newHint, person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Console.WriteLine($"What should {editName}'s relationship to you be? ");
                            string newHint = Console.ReadLine();
                            Acquaintance editedName = new Family(person.GetName(), person.GetBday(), newHint, person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Console.Write($"During what year did you meet {editName}? ");
                            string yearMet = Console.ReadLine();
                            string newHint = $"Since {yearMet}"; 
                            Acquaintance editedName = new Friend(person.GetName(), person.GetBday(), newHint, person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Console.Write($"During what year did you become neighbors with {editName}? ");
                            string yearMet = Console.ReadLine();
                            Console.Write($"In what neighborhood were you neighbors with {editName}? ");
                            string neighborhood = Console.ReadLine();
                            string newHint = $"Lived in {neighborhood} from {yearMet}";
                            Acquaintance editedName = new Neighbor(person.GetName(), person.GetBday(), newHint, person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Console.Write($"Which company did you work together at with {editName}? ");
                            string coworkersAt = Console.ReadLine();
                            string newHint = $"Worked together at {coworkersAt}";
                            Acquaintance editedName = new Coworker(person.GetName(), person.GetBday(), newHint, person.GetChristmas(), keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }                       
                        Console.WriteLine($"{editName} successfully updated.");
                    }
                }
            break;
            case 5:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {
                        Contact keepContact = new Contact(person.GetThePhone(), person.GetTheEmail(), person.GetTheAddress());
                        Console.WriteLine($"Do you want to send a Christmas card to {editName}? (true/false) ");
                        bool card = bool.Parse(Console.ReadLine());
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(person.GetName(), person.GetBday(), person.GetHint(), card, keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(person.GetName(), person.GetBday(), person.GetHint(), card, keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(person.GetName(), person.GetBday(), person.GetHint(), card, keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(person.GetName(), person.GetBday(), person.GetHint(), card, keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(person.GetName(), person.GetBday(), person.GetHint(), card, keepContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }                     
                        Console.WriteLine($"{editName}'s Christmas card sending successfully updated to {card}");
                    }
                }
            break;
            case 6:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {                        
                        Console.Write($"What is {editName}'s correct phone number? Feel free to enter as many as needed: ");
                        string newPhone = Console.ReadLine();
                        Contact updatedContact = new Contact(newPhone, person.GetTheEmail(), person.GetTheAddress());
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }                     
                        Console.WriteLine($"{editName}'s phone number successfully updated to {newPhone}");
                    }
                }
            break;
            case 7:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {                        
                        Console.Write($"What is {editName}'s correct email? ");
                        string newEmail = Console.ReadLine();
                        Contact updatedContact = new Contact(person.GetThePhone(), newEmail, person.GetTheAddress());
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }                     
                        Console.WriteLine($"{editName}'s email address successfully updated to {newEmail}");
                    }
                }
            break;
            case 8:
                foreach (Acquaintance person in contactList)
                {
                    if (String.Equals(editName, person.GetName()))
                    {                        
                        Console.Write($"What is {editName}'s correct mailing address? ");
                        string newAddy = Console.ReadLine();
                        Contact updatedContact = new Contact(person.GetThePhone(), person.GetTheAddress(), newAddy);
                        if (person.GetType().ToString() == "Acquaintance")
                        {
                            Acquaintance editedName = new Acquaintance(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Family")
                        {
                            Acquaintance editedName = new Family(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Friend")
                        {
                            Acquaintance editedName = new Friend(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Neighbor")
                        {
                            Acquaintance editedName = new Neighbor(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }
                        else if (person.GetType().ToString() == "Coworker")
                        {
                            Acquaintance editedName = new Coworker(person.GetName(), person.GetBday(), person.GetHint(), person.GetChristmas(), updatedContact, person.GetHistory());
                            cecc.SaveContact(editName, editedName);
                        }                     
                        Console.WriteLine($"{editName}'s mailing address successfully updated to {newAddy}");
                    }
                }
            break;
        }
        

    }
}