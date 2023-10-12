using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors, getters, and setters will go here
    //Constructor with no parameters, initializing the fraction to 1/1.
    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor with one parameter for the top (numerator) and denominator set to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    //Constructor with two parameters, one for the top and one for the bottom.
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Create Getters and Setters:
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Create methods to return representations:
    public string GetFractionString()
    {
    return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
    return (double)_top / (double)_bottom;
    }
}