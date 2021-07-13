using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Raindrops
{
    public static string Convert(int number)
    {
        var result = new StringBuilder();
        var factors = Factors(number);
        if (factors.Any(f => f == 3))
            result.Append("Pling");
        if (factors.Any(f => f == 5))
            result.Append("Plang");
        if (factors.Any(f => f == 7))
            result.Append("Plong");
        if (result.Length == 0)
            result.Append(number);

        return result.ToString();
    }

    private static IEnumerable<int> Factors(int number)
    {
        for (var i=1; i<=number; i++)
        {
            if (number % i == 0)
                yield return i;
        }
    }
}