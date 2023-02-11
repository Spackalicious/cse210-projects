using System;

class Reference
{
    private string _book;  
    private int _chapter;  
    private int _startVerse;  
    private int _endVerse;  
    
    // Constructor
    public Reference()
    {      
        _book = "John";
        _chapter = 3;
        _startVerse = 16; 
    }
    
    // Constructor
    public Reference(string book, int chapter, int startVerse)
    {        
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    
    // Constructor
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {     
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;   
        _endVerse = endVerse;   
    }

    public string DisplayReference()
    {
        if (_endVerse < 1)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else{
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }        
    }    
}