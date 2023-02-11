using System;
using System.Linq;

class Scripture
{
    
    private string _words;
    private Reference _reference;    
    
    // Constructor
    public Scripture()
    { 
        // default value and uses the default reference
        _words = "For God so loved the world, that He gave His only begotten Son, that whosoever believeth in Him should not perish, but have everlasting life.";   
        _reference = new Reference();   
    }
    
    // Getting rid of this Constructor, because a scripture with only a reference is useless for this program.
    // public Scripture(Reference reference) {}
    
    // Constructor
    public Scripture(Reference reference, string text)
    {        
        _words = text;
        _reference = reference;
    }

    public string GetReference()
    {
        string stringReference = _reference.DisplayReference();        
        return stringReference;
    }

    public string GetText()
    {        
        return _words;
    }

    public int HideWords(int max)
    {                
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0,max); 
        return randomNumber;                
    }
    public string GetRenderedText(List<int> randomNumbers)
    {                
        List<Word> separateWordObjects = StringToList(_words);   
        string renderedText = "";
        foreach (int randomNumber in randomNumbers)
        {
            Word hiddenWord = separateWordObjects[randomNumber];
            hiddenWord.SetHidden();
        }
        foreach (Word item in separateWordObjects)
        {
            renderedText += (item.GetRenderedText() + " ");
        }
        return renderedText;  
    } 

    public int StringWordCount(string _words)
    {
        List<Word> wordString = StringToList(_words);
        int wordCount = CountWords(wordString);
        return wordCount;
    }
    public List<Word> StringToList(string _words)
    {
        List<string> separateWords = _words.Split(' ').ToList();
        List<Word> separateWordObjects = new List<Word> ();          
        // take each word from the string list and add to Word object list
        foreach (string word in separateWords)
        {    
            Word newWord = new Word(word);       
            separateWordObjects.Add(newWord);  
        }    
        return separateWordObjects;
    }

    public int CountWords(List<Word> list)
    {
        int wordCount = list.Count;
        return wordCount;
    }

    public bool IsCompletelyHidden(int wordCount, List<int> randomNumbers)
    {
        bool aBoolean = false;
        if (wordCount == randomNumbers.Count)
        {
            aBoolean = true;
        }        
        return aBoolean;
    }    
}