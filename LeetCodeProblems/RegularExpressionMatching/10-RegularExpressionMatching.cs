namespace LeetCodeProblems.RegularExpressionMatching;

public class _10_RegularExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);

        var firstMatch = !string.IsNullOrEmpty(s) &&
                         (p[0] == s[0] || p[0] == '.');

        if (p.Length >= 2 && p[1] == '*')
            return IsMatch(s, p.Substring(2)) ||
                   (firstMatch && IsMatch(s.Substring(1), p));
        return firstMatch && IsMatch(s.Substring(1), p.Substring(1));
    }
}