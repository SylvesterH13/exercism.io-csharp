using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private List<(string student, int grade)> list;

    public GradeSchool()
    {
        list = new List<(string, int)>();
    }

    public void Add(string student, int grade)
    {
        list.Add((student, grade));
    }

    public IEnumerable<string> Roster()
    {
        return list.OrderBy(l => l.grade).Select(l => l.student).OrderBy(l => l);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return list.Where(l => l.grade == grade).Select(l => l.student).OrderBy(l => l);
    }
}