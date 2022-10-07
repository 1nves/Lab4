using System;

public class FirstClass
{
    virtual internal void InformationInDebug(double firstParameter, string secondParameter)
    {
        Console.WriteLine("Double parameter=" + firstParameter);
        Console.WriteLine("String parameter=" + secondParameter);
    }
}