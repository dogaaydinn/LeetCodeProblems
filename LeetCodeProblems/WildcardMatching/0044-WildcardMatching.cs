namespace LeetCodeProblems.WildcardMatching;

public class _44_WildcardMatching
{
    /*
    Given an input string (s) and a pattern (p), implement wildcard pattern matching with support for '?' and '*' where:
    '?' Matches any single character.
    '*' Matches any sequence of characters (including the empty sequence).
    The matching should cover the entire input string (not partial).
    Approach:
    1. Create a 2D dp array of size m + 1 and n + 1.
    2. Initialize dp[0, 0] as true.
    3. Initialize dp[0, j] as dp[0, j - 1] if p[j - 1] is '*'.
    4. Iterate through the s and p.
    5. If p[j - 1] is '*', then dp[i, j] is dp[i - 1, j] or dp[i, j - 1].
    6. If p[j - 1] is '?' or s[i - 1] is equal to p[j - 1], then dp[i, j] is dp[i - 1, j - 1].
    7. Return dp[m, n].

    Complexity Analysis:
    Time Complexity: O(m * n), where m and n are the lengths of s and p.
    Space Complexity: O(m * n), where m and n are the lengths of s and p.
     */
    public bool IsMatch(string s, string p)
    {
        int m = s.Length, n = p.Length;
        var dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;

        for (var j = 1; j <= n; j++)
            if (p[j - 1] == '*')
                dp[0, j] = dp[0, j - 1];

        for (var i = 1; i <= m; i++)
        for (var j = 1; j <= n; j++)
            if (p[j - 1] == '*')
                dp[i, j] = dp[i - 1, j] || dp[i, j - 1];
            else if (p[j - 1] == '?' || s[i - 1] == p[j - 1]) dp[i, j] = dp[i - 1, j - 1];

        return dp[m, n];
    }
}