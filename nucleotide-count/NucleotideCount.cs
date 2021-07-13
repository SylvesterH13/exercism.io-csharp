using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var count = new Dictionary<char, int>
        {
            { 'A', 0 },
            { 'C', 0 },
            { 'G', 0 },
            { 'T', 0 }
        };
        foreach (var c in sequence)
        {
            if (!count.ContainsKey(c))
                throw new ArgumentException("The sequence has an invalid character!");

            count[c]++;
        }
        return count;
    }
}