using System;
using System.Text;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var result = new StringBuilder();
        var index = 0;
        var n = 0;

        char number;
        for (var i=0; i<2; i++)
        {
            do
            {
                if (index + n >= phoneNumber.Length)
                    throw new ArgumentException();

                number = phoneNumber[index + n];
                n++;
            } while (!NNumber(number));

            result.Append(number);
            index += n;
            n = 0;

            for (var j=0; j<2; j++)
            {
                do
                {
                    if (index + n >= phoneNumber.Length)
                        throw new ArgumentException();

                    number = phoneNumber[index + n];
                    n++;
                } while (!XNumber(number));

                result.Append(number);
                index += n;
                n = 0;
            }
        }
        for (var i=0; i<4; i++)
        {
            do
            {
                if (index + n >= phoneNumber.Length)
                    throw new ArgumentException();

                number = phoneNumber[index + n];
                n++;
            } while (!XNumber(number));

            result.Append(number);
            index += n;
            n = 0;
        }

        return result.ToString();
    }

    private static bool XNumber(char number)
    {
        var n = char.GetNumericValue(number);
        return n >= 0 && n <= 9;
    }

    private static bool NNumber(char number)
    {
        var n = char.GetNumericValue(number);
        return n >= 2 && n <= 9;
    }
}