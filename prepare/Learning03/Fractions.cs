using System;

class Fraction
{
    private int top;
    private int bottom;

    // Constructor with no parameters initializes to 1/1
     public Fraction()
    {
        top = 0;
        bottom = 1;
    }
    // Constructor with one parameters for top and initializes bottom to 1
     public Fraction(int wholeNumber)
    {
        top = wholeNumber;
        bottom = 1;
    }

    // Constructor with two parameters for top and bottom
     public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }
     public int GetTop()
    {
        return top;
    }
     public void SetTop(int value)
    {
        top = value;
    }
     public int GetBottom()
    {
        return bottom;
    }
     public void SetBottom(int value)
    {
        bottom = value;
    }
     public string GetFractionString()
    {
        return top + "/" + bottom;
    }
     public decimal GetDecimalValue()
    {
        return (decimal)top / bottom;
    }
}