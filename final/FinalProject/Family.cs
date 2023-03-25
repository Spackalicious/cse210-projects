using System;
public class Family : Acquaintance
{  
    public Family(string name, DateTime birthday, string hint, bool cardChristmas, Contact contact) : base(name, birthday, hint, cardChristmas, contact)
    {
    } 

    public override void CreatePerson()
    {
        // adjust the CreatePerson to include relationship instead of hint. Or might still be called "hint" in the program, but relationship to the user end. 
    }
}