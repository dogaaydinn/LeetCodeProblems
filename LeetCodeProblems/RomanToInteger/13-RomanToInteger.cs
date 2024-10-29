namespace LeetCodeProblems.RomanToInteger;

public class _13_RomanToInteger
{
    public int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var result = 0;
        var previousValue = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var value = roman[s[i]];

            if (value < previousValue)
                result -= value;
            else
                result += value;

            previousValue = value;
        }

        return result;
    }
}