namespace LeetCodeProblems.LongestPalindromicSubstring;

public static class _005_LongestPalindromicSubstring
{
    /*
    Given a string s, return the longest palindromic substring in s.

    Approach:
        1. Initialize start and end to 0.
        2. Iterate through the string.
        3. For each character, expand the center to the left and right.
        4. If the length is greater than the current end - start, update start and end.
        5. Return the substring from start to end.

        Time complexity: O(n^2), where n is the length of the string.
        Space complexity: O(1)
     */
    public static string LongestPalindrome(string s)
    {
        var start = 0;
        var end = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var len1 = ExpandCenter(s, i, i);
            var len2 = ExpandCenter(s, i, i + 1);

            var len = Math.Max(len1, len2);
            if (len <= end - start) continue;

            start = i - (len - 1) / 2;
            end = i + len / 2;
        }

        return s.Substring(start, end - start + 1);
    }

    private static int ExpandCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }
}