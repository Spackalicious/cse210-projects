using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Let's play Guess the Magic Number!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,111);

        int Guess;
        int i = 0;

        do {
            Console.Write("What is your guess? ");
            Guess = int.Parse(Console.ReadLine());
            
            if (magicNumber < Guess) 
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > Guess)
            {
                Console.WriteLine("Higher");
            }

            i++;
        } while (Guess != magicNumber);
        if (magicNumber == Guess)
            {
                Console.WriteLine($"You guessed it! And it only took you {i} tries!");
                Console.Write("Do you want to play again? Y or N? ");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    // goto ;
                    // Application.Restart();
                    // Program.Main();
                }
            }
    }
}