using System;

public class Contact
{  
    private string _email;
    private string _phone;
    private string _address;
    
    public Contact(string email, string phone, string address)
    {
        _email = email;
        _phone = phone;
        _address = address;
    }

    public string GetEmail()
    {
        return _email;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }

    public string GetPhone()
    {
        return _phone;
    }

    public void SetPhone(string phone)
    {
        _phone = phone;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }


}