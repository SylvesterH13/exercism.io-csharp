using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        var newSystemData = new Dictionary<string, int>();
        foreach (var letters in old)
        {
            foreach (var l in letters.Value)
            {
                newSystemData.Add(l.ToLower(), letters.Key);
            }
        }
        return newSystemData;
    }
}