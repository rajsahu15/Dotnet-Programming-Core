using System;

class Calculator
{
    // compile time
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum of two: " + (a + b));
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum of three: " + (a + b + c));
    }
}

class Shape
{
    // runtime
    public virtual void Draw() { Console.WriteLine("Drawing a shape."); }
}

class Circle : Shape
{
    public override void Draw() { Console.WriteLine("Drawing a Circle."); }
}
public class Polymorphism {
    public static void Main(string[] args) {
        Calculator calculator = new Calculator();
        calculator.Add(10,20);
        calculator.Add(10,20,30);
        Shape shape = new Circle();
        shape.Draw();
    }
}