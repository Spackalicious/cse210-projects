using System;

public class ContactCreator
{      
    
    public ContactCreator()
    {
    }

    public void AddContact()
    {
        Console.WriteLine("Let's add a contact!");
        Console.WriteLine("What type of contact are you creating?");
        Console.WriteLine("   1. Acquaintance");
        Console.WriteLine("   2. Family Member");
        Console.WriteLine("   3. Friend");
        Console.WriteLine("   4. Neighbor");
        Console.WriteLine("   5. Coworker");
        Console.Write("Please enter your selection: ");
        int createType = int.Parse(Console.ReadLine());
        switch (createType)
        {
            case 1:
                Acquaintance person = new Acquaintance();
                person.CreatePerson();
            break;
            case 2:
                Acquaintance newFamily = new Family();
                newFamily.CreatePerson();
            break;
            case 3:
                Acquaintance newFriend = new Friend();
                newFriend.CreatePerson();
            break;
            case 4:
                Acquaintance newNeighbor = new Neighbor();
                newNeighbor.CreatePerson();
            break;
            case 5:
                Acquaintance newCoworker = new Coworker();
                newCoworker.CreatePerson();
            break;
        } 
    }

    public DateTime CreateBirthday(string name)
    {
        DateTime birthday = new DateTime(0001, 1, 1);
        Console.Write($"Do you know {name}'s birthday? (yes/no) ");
        string birthdayResponse = Console.ReadLine();
        if (birthdayResponse == "yes")
        {
            Console.Write($"What is {name}'s birth month in numbers? ");
            int birthmonth = int.Parse(Console.ReadLine());
            Console.Write($"What is {name}'s birth day number? ");
            int birthDay = int.Parse(Console.ReadLine());
            Console.Write($"What is {name}'s birth year? (if you don't know, just enter four zeros) ");
            int birthyear = int.Parse(Console.ReadLine());
            if (birthyear == 0000)
            {
                birthday = new DateTime(1900, birthmonth, birthDay);                
            }
            else if (birthyear > 1900)
            {                
                birthday = new DateTime(birthyear, birthmonth, birthDay);                
            }
        }
        return birthday;
    }

    public Contact CreateContactInfo(string name)
    {
        Console.Write($"What is {name}'s phone number? ");
        string phone = Console.ReadLine();
        Console.Write($"What is {name}'s email address? ");
        string email = Console.ReadLine();
        Console.Write($"What is {name}'s mailing address? ");
        string mail = Console.ReadLine();
        
        Contact contact = new Contact(phone, email, mail);
        return contact;
    }

    public bool ChristmasCard(string name)
    {
        Console.Write("And last: Do you want to send this person a Christmas card? true or false? ");
        bool cardChristmas = bool.Parse(Console.ReadLine());
        return cardChristmas;
    }

    public void SaveContact(string name, Acquaintance acquaintance)
    {
        string contactFile = $@"contacts\{name}.txt";
        using (StreamWriter sw = new StreamWriter(contactFile))
        {                        
            string objectType = acquaintance.GetType().ToString();     
            sw.Write($"{objectType}|");                                  
            sw.Write($"{acquaintance.GetName()}|");                                  
            sw.Write($"{acquaintance.GetBday()}|");                                  
            sw.Write($"{acquaintance.GetHint()}|");                                  
            sw.Write($"{acquaintance.GetChristmas()}|");                                  
            sw.Write($"{acquaintance.GetThePhone()}|");                                  
            sw.Write($"{acquaintance.GetTheEmail()}|");                                  
            sw.Write($"{acquaintance.GetTheAddress()}>>"); 
            sw.Write($"{acquaintance.GetHistory()}");                                 
        }
        Console.WriteLine($"Entry saved to {name}.txt \n"); 
    }
}