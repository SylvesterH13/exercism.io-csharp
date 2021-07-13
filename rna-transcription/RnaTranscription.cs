using System;
using System.Text;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var rna = new StringBuilder();
        foreach (var n in nucleotide)
        {
            if (n == 'A')
                rna.Append('U');
            else if (n == 'C')
                rna.Append('G');
            else if (n == 'G')
                rna.Append('C');
            else if (n == 'T')
                rna.Append('A');
            else
                throw new ArgumentException("The nucletide strand is not valid!");
        }
        return rna.ToString();
    }
}