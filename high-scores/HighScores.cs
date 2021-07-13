using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> list;

    public HighScores(List<int> list)
    {
        this.list = list;
    }

    public List<int> Scores()
    {
        return list;
    }

    public int Latest()
    {
        return list.Last();
    }

    public int PersonalBest()
    {
        return list.OrderByDescending(s => s).First();
    }

    public List<int> PersonalTopThree()
    {
        return list.OrderByDescending(s => s).Take(3).ToList();
    }
}