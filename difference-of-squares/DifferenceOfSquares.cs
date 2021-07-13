using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return (int)Math.Pow(Enumerable.Range(1, max).Sum(n => n), 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        return (int)Enumerable.Range(1, max).Sum(n => Math.Pow(n, 2));
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}