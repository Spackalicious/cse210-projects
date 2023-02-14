using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment practice0 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(practice0.GetSummary());
        Console.WriteLine();

        MathAssignment practice1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(practice1.GetSummary());
        Console.WriteLine(practice1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment practice2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(practice2.GetSummary());
        Console.WriteLine(practice2.GetWritingInformation());
    }
}