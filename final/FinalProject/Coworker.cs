using System;
public class Coworker : Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    private string _history = "";
    
    public Coworker() : base()
    {
    } 
    public Coworker(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact, string history) : base(name, birthday, hint, cardChristmas, contact, history)
    {
    } 

    public override void CreatePerson()
    {
        Console.Write("What is your coworker's name? ");
        _name = Console.ReadLine();
        Console.Write($"Which company did you work together at with {_name}? ");
        string coworkersAt = Console.ReadLine();
        _hint = $"Worked together at {_hint}";

        ContactCreator cc = new ContactCreator();
        _birthday = cc.CreateBirthday(_name); 
        _contact = cc.CreateContactInfo(_name); 
        _cardChristmas = cc.ChristmasCard(_name); 
        
        Acquaintance newCoworker = new Coworker(_name, _birthday, _hint, _cardChristmas, _contact, _history);
        cc.SaveContact(_name, newCoworker);
    }
}