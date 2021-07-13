public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input.Length == 0)
            return string.Empty;

        var reverse = new char[input.Length];
        for (var i=0; i<input.Length; i++)
        {
            reverse[input.Length - 1 - i] = input[i];
        }
        return new string(reverse);
    }
}