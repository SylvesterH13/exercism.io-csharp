using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{

    private List<Allergen> list;

    public Allergies(int mask)
    {
        list = new List<Allergen>();
        if (mask == 0)
            return;

        for (var i = 0; i < (int)Allergen.Cats + 1; i++) {
            var score = (int)Math.Pow(2, i);
            if ((score & mask) == score)
            {
                list.Add((Allergen)i);
            }
        }
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return list.Contains(allergen);
    }

    public Allergen[] List()
    {
        return list.ToArray();
    }
}