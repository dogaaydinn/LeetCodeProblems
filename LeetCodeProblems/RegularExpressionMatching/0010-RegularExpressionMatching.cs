namespace LeetCodeProblems.RegularExpressionMatching;

public class _10_RegularExpressionMatching
{
    /*
     Problem: 10. Regular Expression Matching

        Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where:
        '.' Matches any single character.
        '*' Matches zero or more of the preceding element.
        The matching should cover the entire input string (not partial).

        Approach:
            1. If the pattern is empty, return true if the string is empty.
            2. Check if the first character of the string matches the first character of the pattern.
            3. If the second character of the pattern is '*', check if the pattern matches the string without the first two characters of the pattern or the string without the first character.
            4. If the second character of the pattern is not '*', check if the first character of the string matches the first character of the pattern and the rest of the string matches the rest of the pattern.
            5. Return true if the first character of the string matches the first character of the pattern and the rest of the string matches the rest of the pattern.

            Time complexity: O(2^n)
            Space complexity: O(1)
     */
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