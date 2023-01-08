using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of positive and negative numbers, type 0 when finished. ");

        List<float> numbers = new List<float>();
        float newNum;
        float sum = 0;
        int i = 0;
        float highest = 0;
        float smallestPos = 111;
        do {
            Console.Write("Enter number: ");
            newNum = float.Parse(Console.ReadLine());
            if (newNum !=0)
            {
                numbers.Add(newNum);
                sum += newNum;
                i++;
            }            
            if (newNum > highest)
            {
                highest = newNum; 
            }
            if (newNum > 0 && newNum < smallestPos)
            {
                smallestPos = newNum;
            }
        } while (newNum != 0);               
       

        float average = sum / i;
        // string avg = average.ToString("N5");
        Console.WriteLine($"The sum is: {sum}");
        // Console.WriteLine($"The total number of list items is {i}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {highest}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (float number in numbers) 
        {
            Console.WriteLine(number);
        }
    }
}