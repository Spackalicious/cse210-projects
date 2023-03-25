using System;
public class Friend : Acquaintance
{  
    public Friend(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact) : base(name, birthday, hint, cardChristmas, contact)
    {
    } 

    public override void CreatePerson()
    {
        // adjust the CreatePerson to include _yearsKnown instead of hint. Or might still be called "hint" in the program, but duration of relationship to the user. 
    }
    
}