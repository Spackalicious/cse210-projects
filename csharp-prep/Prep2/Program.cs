using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string letter;

        if (grade >= 90) 
        {
            letter = "n A";
        }
        else if (grade >= 80 && grade < 90) 
        {
            letter = " B";
        }
        else if (grade >= 70 && grade < 80) 
        {
            letter = " C";
        }
        else if (grade >= 60 && grade < 70) 
        {
            letter = " D";
        }
        else 
        {
            letter = "n F";
        }

        int remainder = grade % 10;
        string sign;
        if (remainder >=7 && grade < 90 && grade > 60)
        {
            sign = "+";
        }
        else if (remainder <= 3 && grade > 60)
        {
            sign = "-";
        }
        else 
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is a{letter}{sign}");
        
        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations, you've passed the course!");
        }
        else 
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}