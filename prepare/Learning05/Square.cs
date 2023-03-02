using System;
public class Square : Shape
{  
    private double _side;

    public Square(string color, double side, string name = "square") : base(color, name)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}