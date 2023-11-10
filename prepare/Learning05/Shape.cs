using System;

public abstract class Shape // if not put abstract will show debug
{
    private string _color;
    
    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    //public virtual double GetArea()
    //{
        // This is a virtual method, to be overridden by subclasses
       // return 0;
    //}
    public abstract double GetArea();

}

// We can instead declare the function as an "abstract" function. That means
    // that it is an empty virtual function that must be implemented or "filled in" by
    // any class that inherits from Shape. Then, any class that has an abstract method
    // must also be declared to be abstract.