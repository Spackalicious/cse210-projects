using System;
public class Friend : Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    private string _history = "";
    
    public Friend() : base()
    {
    } 
    public Friend(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact, string history) : base(name, birthday, hint, cardChristmas, contact, history)
    {
    } 

    public override void CreatePerson()
    {
        Console.Write("What is your friend's name? ");
        _name = Console.ReadLine();
        Console.Write($"During what year did you meet {_name}? ");
        string yearMet = Console.ReadLine();
        _hint = $"Since {yearMet}";        
       
        ContactCreator cc = new ContactCreator();
        _birthday = cc.CreateBirthday(_name); 
        _contact = cc.CreateContactInfo(_name); 
        _cardChristmas = cc.ChristmasCard(_name); 
        
        Acquaintance friend = new Friend(_name, _birthday, _hint, _cardChristmas, _contact, _history);
        cc.SaveContact(_name, friend);
    }    
}