using System;
public class Neighbor : Acquaintance
{  
    private string _name;
    private DateTime _birthday = new DateTime(0001, 1, 1);
    private string _hint;
    private bool _cardChristmas;
    private Contact _contact;
    private string _history = "";
    
    public Neighbor() : base()
    {
    } 
    public Neighbor(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact, string history) : base(name, birthday, hint, cardChristmas, contact, history)
    {
    } 

    public override void CreatePerson()
    {
        Console.Write("What is your neighbor's name? ");
        _name = Console.ReadLine();
        Console.Write($"During what year did you become neighbors with {_name}? ");
        string yearMet = Console.ReadLine();
        Console.Write($"In what neighborhood were you neighbors with {_name}? ");
        string neighborhood = Console.ReadLine();
        _hint = $"Lived in {neighborhood} from {yearMet}";
        
        ContactCreator cc = new ContactCreator();
        _birthday = cc.CreateBirthday(_name); 
        _contact = cc.CreateContactInfo(_name); 
        _cardChristmas = cc.ChristmasCard(_name);
        
        Acquaintance newNeighbor = new Neighbor(_name, _birthday, _hint, _cardChristmas, _contact, _history);
        cc.SaveContact(_name, newNeighbor);       
    }
}
    // adjust the Events to include things borrowed, service, things in common, etc. 
    
