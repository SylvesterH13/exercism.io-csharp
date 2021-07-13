public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        return input.Length == 0 ? -1 : FindRecursive(0, input.Length-1, input, value);
    }

    private static int FindRecursive(int begin, int end, int[] input, int value)
    {
        if (begin == end)
        {
            if (value == input[begin])
                return begin;

            return -1;
        }
        int middleIndex = begin + ((end - begin) / 2);
        if (value <= input[middleIndex])
        {
            return FindRecursive(begin, middleIndex, input, value);
        }
        return FindRecursive(middleIndex + 1, end, input, value);
    }
}