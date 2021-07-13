using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (string.IsNullOrWhiteSpace(numbers) || sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException();

        var substrings = new List<string>();
        for (var i=0; i + sliceLength <= numbers.Length; i++)
        {
            substrings.Add(numbers.Substring(i, sliceLength));
        }
        return substrings.ToArray();
    }
}