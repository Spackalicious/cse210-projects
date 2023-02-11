using System;

class Word
{
    private string _word;  
    private bool _hidden; 
    
    // Constructor
    public Word(string word, bool _hidden = false)
    {        
        _word = word;
    }
    
    public string ShowWord()
    {
        // return (_word + " (" + _hidden + "), ");
        return (_word);
    }

    public string HideWord()
    {
        string s = "";
        int i = 0;
        while (i < _word.Length)
        {           
            s += "_";
            i++;
        }
        return s;
    }

    public bool SetHidden()
    {
        _hidden = true;
        return _hidden;
    }

    public string GetRenderedText()
    {
        if (_hidden) 
        {
            _word = HideWord();
        }
        else 
        {
            _word = ShowWord();
        }        
        return _word;
    }
}