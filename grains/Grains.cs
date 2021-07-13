using System;

public static class Grains
{
    private const int MaxChestSquares = 64;

    public static ulong Square(int n)
    {
        if (n <= 0 || n > MaxChestSquares)
            throw new ArgumentOutOfRangeException();

        return (ulong)Math.Pow(2, n-1);
    }

    public static ulong Total()
    {
        ulong total = 0;
        var current = 1;
        for (var square = 1; square <= MaxChestSquares; square++)
        {
            total += (ulong)current;
            current *= 2;
        }
        return total;
    }
}