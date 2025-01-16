namespace _75InterviewQuestion.IsSubsequence;

public class _392_IsSubsequence
{
    /*
     * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
     * A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters.
     * (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
     *
     * Approach:
     * 1. Initialize two pointers i and j to 0.
     * 2. Iterate over the s and t strings.
     * 3. If the characters at the i-th position of s and j-th position of t are equal, increment i.
     * 4. Increment j.
     * 5. If i is equal to the length of s, return true.
     * 6. If no subsequence is found, return false.
     *
     * Time complexity: O(n + m), where n is the length of s and m is the length of t.
     * Space complexity: O(1).
     */
    //first solution

    public bool IsSubsequence(string s, string t)
    {
        var substring = s;
        var mainString = t;

        if (t.Length < s.Length) return false;

        var i = 0;
        while (i < substring.Length && mainString.Length > 0)
        {
            if (mainString[0] == substring[i]) i++;
            mainString = mainString.Substring(1);
        }

        return i == substring.Length;
    }

    //second solution
    public bool IsSubsequence2(string s, string t)
    {
        if (s.Length > t.Length) return false;

        var i = 0;
        var j = 0;

        while (i < s.Length && j < t.Length)
        {
            if (s[i] == t[j]) i++;
            j++;
        }

        return i == s.Length;
    }
}