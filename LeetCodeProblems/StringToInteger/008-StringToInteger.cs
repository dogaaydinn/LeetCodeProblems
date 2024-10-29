namespace LeetCodeProblems.StringToInteger;

public static class _008_StringToInteger
{
    public static int MyAtoi(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int i = 0, sign = 1, result = 0;
        var n = s.Length;

        while (i < n && s[i] == ' ') i++;

        if (i < n && (s[i] == '+' || s[i] == '-'))
        {
            sign = s[i] == '-' ? -1 : 1;
            i++;
        }

        while (i < n && s[i] >= '0' && s[i] <= '9')
        {
            var digit = s[i] - '0';

            if (result > (int.MaxValue - digit) / 10) return sign == 1 ? int.MaxValue : int.MinValue;

            result = result * 10 + digit;
            i++;
        }

        return result * sign;
    }
}