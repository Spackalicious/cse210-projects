using System;

public class Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    private string _history;
    
    public Acquaintance()
    {
    }
    public Acquaintance(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact, string history)
    {
        _name = name;
        _birthday = birthday;
        _hint = hint;
        _cardChristmas = cardChristmas;
        _contact = contact;
        _history = history;
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

    public string GetHistory()
    {
        return _history;
    }

    public virtual void CreatePerson()
    {
        Console.Write("What is your acquaintance's name? ");
        _name = Console.ReadLine();
        Console.Write($"How do you know {_name}? ");
        _hint = Console.ReadLine();
       
        ContactCreator cc = new ContactCreator();
        _birthday = cc.CreateBirthday(_name); 
        _contact = cc.CreateContactInfo(_name); 
        _cardChristmas = cc.ChristmasCard(_name); 
        
        Acquaintance acquaintance = new Acquaintance(_name, _birthday, _hint, _cardChristmas, _contact, _history);
        cc.SaveContact(_name, acquaintance);
    }

    // public abstract void IsComplete();    
    // public abstract string DisplayGoal(Goal goal);    
    // public abstract string GoalText(Goal goal);
    // public virtual int GetBonus()
    // {
    //     return 0;
    // }
}