using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("To calculate tha hamming distance the two strands must have the same length!");

        var distance = 0;
        for (var i=0; i<firstStrand.Length; i++)
        {
            if (firstStrand[i] != secondStrand[i])
                distance++;
        }

        return distance;
    }
}