using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        return Enumerable.Range(1, max - 1)
            .Sum(i => multiples.FirstOrDefault(m => m != 0 && i % m == 0) == 0 ? 0 : i);
    }
}