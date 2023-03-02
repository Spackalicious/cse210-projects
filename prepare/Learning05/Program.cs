using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 4);
        // string squareCol = square1.GetColor();
        // double squareArea = square1.GetArea();
        // Console.WriteLine($"The color of the square is {squareCol} and the area of the square is {squareArea}.\n");

        Rectangle rectangle1 = new Rectangle ("yellow", 5, 6);
        // string rectCol = rectangle1.GetColor();
        // double rectArea = rectangle1.GetArea();
        // Console.WriteLine($"The color of the rectangle is {rectCol} and the area of the rectangle is {rectArea}.\n");

        Circle circle1 = new Circle ("pink", 7);
        circle1.SetColor("magenta");
        // string circleCol = circle1.GetColor();
        // double circleArea = circle1.GetArea();
        // Console.WriteLine($"The color of the circle is {circleCol} and the area of the circle is {circleArea}.\n");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string shapeCol = shape.GetColor();
            double shapeArea = shape.GetArea();
            string shapeName = shape.GetName();
            Console.WriteLine($"The {shapeCol} {shapeName}'s area is {shapeArea} units squared. \n");
        }
    }
}