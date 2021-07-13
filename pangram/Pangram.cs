using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var alphabet = new string(Enumerable.Range('a', 26).Select(letter => (char)letter).ToArray());
        foreach (var letter in input.ToLower())
        {
            alphabet = alphabet.Replace(letter.ToString(), "");
        }
        return alphabet.Length == 0;
    }
}