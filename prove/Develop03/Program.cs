using System;

class Program
{
    static void Main()
    {
        string _answer = "";
        do 
        {        
        List<int> _randomNumbers = new List<int> ();        
        
        
        Console.WriteLine("What would you like to do? ");
        Console.WriteLine("1. Memorize John 3:16 ");
        Console.WriteLine("2. Memorize Proverbs 3:5-6  ");
        Console.WriteLine("3. Input your own verse to memorize ");
        Console.WriteLine("4. Quit ");
        _answer = Console.ReadLine();
        string response = "";
        switch (_answer)
        {
            case "1":
                Scripture s1 = new Scripture();
                do 
                {                       
                    Console.WriteLine(s1.GetReference());
                    Console.WriteLine(s1.GetRenderedText(_randomNumbers));
                    Console.WriteLine(); 
                    int times = 0;
                    string text = s1.GetText();
                    int wordCount = s1.StringWordCount(text);
                    while (times < 3)
                    {
                        int randomNumber = s1.HideWords(wordCount);
                        if (!_randomNumbers.Contains(randomNumber)) 
                        {
                            _randomNumbers.Add(randomNumber);
                        }                       
                        times ++;
                    }                    
                    Console.Write("Press enter to continue or type 'menu' to return to the main menu: ");
                    response = Console.ReadLine();
                    Console.Clear();
                } while (response != "menu" && !s1.IsCompletelyHidden(s1.StringWordCount(s1.GetText()), _randomNumbers));                
            break;        
            case "2":
                Reference _s2ref = new Reference("Proverbs", 3, 5, 6);
                string _s2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."; 
                Scripture s2 = new Scripture(_s2ref, _s2);
                do 
                {                     
                    Console.WriteLine(s2.GetReference());
                    Console.WriteLine(s2.GetRenderedText(_randomNumbers));
                    Console.WriteLine(); 
                    int times = 0;
                    string text = s2.GetText();
                    int wordCount = s2.StringWordCount(text);
                    while (times < 3)
                    {
                        int randomNumber = s2.HideWords(wordCount);
                        if (!_randomNumbers.Contains(randomNumber)) 
                        {
                            _randomNumbers.Add(randomNumber);
                        }                       
                        times ++;
                    }                    
                    Console.Write("Press enter to continue or type 'menu' to return to the main menu: ");
                    response = Console.ReadLine();
                    Console.Clear();
                } while (response != "menu" && !s2.IsCompletelyHidden(s2.StringWordCount(s2.GetText()), _randomNumbers));                
            break;
            case "3":
                Console.Write("Please enter the book of your scripture: ");
                string s3book = Console.ReadLine();
                Console.Write("Please enter the chapter of your scripture: ");
                int s3chapter = int.Parse(Console.ReadLine());
                Console.Write("Please enter the starting verse of your scripture: ");
                int s3startVerse = int.Parse(Console.ReadLine());
                Console.Write("Please enter the ending verse of your scripture, or enter 0 if there is only one verse: ");
                int s3endVerse = 0;
                Reference s3ref = new Reference();
                s3endVerse = int.Parse(Console.ReadLine());
                if (s3endVerse == 0)
                {
                    s3ref = new Reference(s3book, s3chapter, s3startVerse);
                }
                else
                {
                    s3ref = new Reference(s3book, s3chapter, s3startVerse, s3endVerse);
                }                
                Console.WriteLine("Please enter the text of your verse: ");
                string s3text = Console.ReadLine();
                Scripture s3 = new Scripture(s3ref, s3text);
                Console.WriteLine("Thank you. Enjoy memorizing your scripture: ");
                do 
                {                     
                    Console.WriteLine(s3.GetReference());
                    Console.WriteLine(s3.GetRenderedText(_randomNumbers));
                    Console.WriteLine(); 
                    int times = 0;
                    string text = s3.GetText();
                    int wordCount = s3.StringWordCount(text);
                    while (times < 3)
                    {
                        int randomNumber = s3.HideWords(wordCount);
                        if (!_randomNumbers.Contains(randomNumber)) 
                        {
                            _randomNumbers.Add(randomNumber);
                        }                       
                        times ++;
                    }                    
                    Console.Write("Press enter to continue or type 'menu' to return to the main menu: ");
                    response = Console.ReadLine();
                    Console.Clear();
                } while (response != "menu" && !s3.IsCompletelyHidden(s3.StringWordCount(s3.GetText()), _randomNumbers)); 
            break;
            case "4":
                _answer = "quit";
            break;        
        }
        } while (_answer != "quit");      
    }
}