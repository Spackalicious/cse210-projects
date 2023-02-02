using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine($"f1's top is {f1.GetTop()}");
        Console.WriteLine("Changing f1's top");
        f1.SetTop(2);
        Console.WriteLine($"f1's top is now {f1.GetTop()}");

        Console.WriteLine($"f2's bottom is {f2.GetBottom()}");
        Console.WriteLine("Changing f2's bottom");
        f2.SetBottom(5);
        Console.WriteLine($"f2's bottom is now {f2.GetBottom()}");

        Console.WriteLine($"f3 is {f3.GetFractionString()}");
        Console.WriteLine($"f3 as a decimal is {f3.GetDecimalValue()}");
        Console.WriteLine("Changing f3!");
        f3.SetTop(3);
        f3.SetBottom(4);
        Console.WriteLine($"f3 is now {f3.GetFractionString()}");
        Console.WriteLine($"f3 as a decimal is now {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue ());

        Fraction f5 = new Fraction(5);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue ());

        Fraction f6 = new Fraction(3, 4);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue ());

        Fraction f7 = new Fraction(1, 3);
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue ());

    }
}