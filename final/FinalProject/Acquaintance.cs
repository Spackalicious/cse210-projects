using System;

public class Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1, 12, 00, 00);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    
    public Acquaintance()
    {
    }
    public Acquaintance(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact)
    {
        _name = name;
        _birthday = birthday;
        _hint = hint;
        _cardChristmas = cardChristmas;
        _contact = contact;
    }

    public string GetTheEmail()
    {
        return _contact.GetEmail();
    }

    public string GetThePhone()
    {
        return _contact.GetPhone();
    }

    public string GetTheAddress()
    {
        return _contact.GetAddress();
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public DateTime GetBday()
    {
        return _birthday;
    }
    public void SetBday(DateTime bday)
    {
        _birthday = bday;
    }
    public string GetHint()
    {
        return _hint;
    }
    public bool GetChristmas()
    {
        return _cardChristmas;
    }
    public void SetChristmas(bool cardChristmas)
    {
        _cardChristmas = cardChristmas;
    }

    public virtual void CreatePerson()
    {
        Console.Write("What is your contact's name? ");
        _name = Console.ReadLine();
        Console.Write("How do you know this person? ");
        _hint = Console.ReadLine();
        Console.Write("What is your contact's birth year? If you don't know, just enter four zeros: ");
        // DateTime birthdate = new DateTime(1899, 1, 1, 12, 00, 00);
        int birthyear = int.Parse(Console.ReadLine());
        if (birthyear == 0000)
        {
            _birthday = new DateTime(0001, 1, 1, 12, 00, 00);
        }
        else if (birthyear > 1900)
        {
            Console.Write("What is your contact's birth month in numbers? ");
            int birthmonth = int.Parse(Console.ReadLine());
            Console.Write("What is your contact's birth day number? ");
            int birthDay = int.Parse(Console.ReadLine());
            _birthday = new DateTime(birthyear, birthmonth, birthDay, 12, 00, 00);
        }
        Console.Write("What is your person's email address? ");
        string email = Console.ReadLine();
        Console.Write("What is your person's phone number? ");
        string phone = Console.ReadLine();
        Console.Write("What is your person's mailing address? ");
        string mail = Console.ReadLine();
        Console.Write("And last: Do you want to send this person a Christmas card? true or false? ");
        _cardChristmas = bool.Parse(Console.ReadLine());
        _contact = new Contact(email, phone, mail);
        Acquaintance acquaintance1 = new Acquaintance(_name, _birthday, _hint, _cardChristmas, _contact);

        string contactFile = $@"contacts\{_name}.txt";
        using (StreamWriter sw = new StreamWriter(contactFile))
        {                        
            string objectType = acquaintance1.GetType().ToString();     
            sw.Write($"{objectType}|");                                  
            sw.Write($"{acquaintance1.GetName()}|");                                  
            sw.Write($"{acquaintance1.GetBday()}|");                                  
            sw.Write($"{acquaintance1.GetHint()}|");                                  
            sw.Write($"{acquaintance1.GetChristmas()}|");                                  
            sw.Write($"{_contact.GetEmail()}|");                                  
            sw.Write($"{_contact.GetPhone()}|");                                  
            sw.Write($"{_contact.GetAddress()}>>");                                  
        }
        Console.WriteLine($"Entries saved to {_name}.txt \n"); 
    }

    // public abstract void IsComplete();    
    // public abstract string DisplayGoal(Goal goal);    
    // public abstract string GoalText(Goal goal);
    // public virtual int GetBonus()
    // {
    //     return 0;
    // }
}