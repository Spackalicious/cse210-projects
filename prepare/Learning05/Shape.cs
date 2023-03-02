using System;
public abstract class Shape
{  
    private string _color;
    private string _name;
    
    public Shape(string color, string name)
    {
        _color = color;
        _name = name;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetName()
    {
        return _name;
    }
    // public virtual double GetArea()
    // {
    //     return 54.5;
    // }
    public abstract double GetArea();
}