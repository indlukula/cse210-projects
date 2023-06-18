using System;

public class Circle : Shape
{
    // Attributes 
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    // Methods
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }

  }