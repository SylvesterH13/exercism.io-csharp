using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numberString = number.ToString();
        var sum = 0;
        foreach (var n in numberString)
        {
            sum += (int)Math.Pow(double.Parse(n.ToString()), numberString.Length);
        }
        return sum == number;
    }
}