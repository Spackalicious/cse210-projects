using System;
public class Coworker : Acquaintance
{  
    public Coworker(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact) : base(name, birthday, hint, cardChristmas, contact)
    {
    } 

    public override void CreatePerson()
    {
        // adjust the CreatePerson to include _company instead of hint. Or might still be called "hint" in the program, but company to the user end. 
    }
}