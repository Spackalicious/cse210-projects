using System;
public class Neighbor : Acquaintance
{  
    public Neighbor(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact) : base(name, birthday, hint, cardChristmas, contact)
    {
    } 

    public override void CreatePerson()
    {
        // adjust the CreatePerson to include details about the relationship, like things borrowed, service, things in common, instead of just hint. 
    }
    
}