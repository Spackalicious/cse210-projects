using System;
public class Family : Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    private string _history = "";
    
    public Family() : base()
    {
    } 

    public Family(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact, string history) : base(name, birthday, hint, cardChristmas, contact, history)
    {
    } 

    public override void CreatePerson()
    {
        Console.Write("What is your family member's name? ");
        _name = Console.ReadLine();
        Console.Write($"How is {_name} related to you? ");
        _hint = Console.ReadLine();
        
        ContactCreator cc = new ContactCreator();
        _birthday = cc.CreateBirthday(_name); 
        _contact = cc.CreateContactInfo(_name); 
        _cardChristmas = cc.ChristmasCard(_name);

        Acquaintance familyMember = new Family(_name, _birthday, _hint, _cardChristmas, _contact, _history);
        cc.SaveContact(_name, familyMember);          
    }
}