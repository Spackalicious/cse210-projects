using System;

// **** moved the only method into Acquaintance in order to override in the sub classes. Probably can delete this class altogether. 

public class ContactCreator
{  
    // private DateTime _lastContact;
    
    public ContactCreator()
    {
    }

    // public void CreatePerson()
    // {
    //     Console.Write("What is your contact's name? ");
    //     string name = Console.ReadLine();
    //     Console.Write("How do you know this person? ");
    //     string hint = Console.ReadLine();
    //     Console.Write("What is your contact's birth year? If you don't know, just enter four zeros: ");
    //     DateTime birthdate = new DateTime(1899, 1, 1, 12, 00, 00);
    //     int birthyear = int.Parse(Console.ReadLine());
    //     if (birthyear == 0000)
    //     {
    //         birthdate = new DateTime(0001, 1, 1, 12, 00, 00);
    //     }
    //     else if (birthyear > 1900)
    //     {
    //         Console.Write("What is your contact's birth month in numbers? ");
    //         int birthmonth = int.Parse(Console.ReadLine());
    //         Console.Write("What is your contact's birth day number? ");
    //         int birthDay = int.Parse(Console.ReadLine());
    //         birthdate = new DateTime(birthyear, birthmonth, birthDay, 12, 00, 00);
    //     }
    //     Console.Write("What is your person's email address? ");
    //     string email = Console.ReadLine();
    //     Console.Write("What is your person's phone number? ");
    //     string phone = Console.ReadLine();
    //     Console.Write("What is your person's mailing address? ");
    //     string mail = Console.ReadLine();
    //     Console.Write("And last: Do you want to send this person a Christmas card? true or false? ");
    //     bool card = bool.Parse(Console.ReadLine());
    //     Contact contact1 = new Contact(email, phone, mail);
    //     Acquaintance acquaintance1 = new Acquaintance(name, birthdate, hint, card, contact1);

    //     string contactFile = $@"contacts\{name}.txt";
    //     using (StreamWriter sw = new StreamWriter(contactFile))
    //     {                        
    //         string objectType = acquaintance1.GetType().ToString();     
    //         sw.Write($"{objectType}|");                                  
    //         sw.Write($"{acquaintance1.GetName()}|");                                  
    //         sw.Write($"{acquaintance1.GetBday()}|");                                  
    //         sw.Write($"{acquaintance1.GetHint()}|");                                  
    //         sw.Write($"{acquaintance1.GetChristmas()}|");                                  
    //         sw.Write($"{contact1.GetEmail()}|");                                  
    //         sw.Write($"{contact1.GetPhone()}|");                                  
    //         sw.Write($"{contact1.GetAddress()}>>");                                  
    //     }
    //     Console.WriteLine($"Entries saved to {name}.txt \n"); 
    // }


}