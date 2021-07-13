using System;
using System.Collections.Generic;

public class Robot
{
    private string _name;
    private static readonly List<string> Names = new List<string>();

    public string Name
    {
        get
        {
            return _name;
        }
    }

    public Robot()
    {
        Reset();
    }

    public void Reset()
    {
        string name;
        do
        {
            var random = new Random();
            var firstLetter = (char)random.Next('A', 'Z' + 1);
            var secondLetter = (char)random.Next('A', 'Z' + 1);
            var number = random.Next(0, 1000);
            var numberString = number.ToString().PadLeft(3, '0');
            name = new string(new char[] { firstLetter, secondLetter }) + numberString;
        }
        while (Names.Contains(name));

        _name = name;
        Names.Add(name);
    }
}