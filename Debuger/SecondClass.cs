using System;

public class SecondClass : FirstClass
{
    internal override void InformationInDebug(double firstParameter, string secondParameter)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("First parameter type " + firstParameter.GetType());
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Second parametr type " + secondParameter.GetType());
        Console.ReadLine();
    }
}
