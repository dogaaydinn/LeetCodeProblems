namespace LeetCodeProblems.LongestCommonPrefix;

public class _14_LongestCommonPrefix
{
    /*
        * Problem: 14. Longest Common Prefix
        * URL: https://leetcode.com/problems/longest-common-prefix/
     Given an array of strings strs, return the longest common prefix of all strings in strs. If there is no common prefix, return an empty string.

        Approach:
            1. If the length of the input array is 0, return an empty string.
            2. Initialize the prefix as the first string in the array.
            3. Iterate through the array starting from the second string.
            4. While the index of the prefix in the current string is not 0, remove the last character from the prefix.
            5. If the prefix is empty, return an empty string.
            6. Return the prefix.

            Time complexity: O(n * m), where n is the number of strings in the array and m is the length of the longest string.
            Space complexity: O(1)
     */
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";

        var prefix = strs[0];

        for (var i = 1; i < strs.Length; i++)
            while (strs[i].IndexOf(prefix, StringComparison.Ordinal) != 0)
            {
                prefix = prefix[..^1];

                if (prefix.Length == 0) return "";
            }

        return prefix;
    }
}