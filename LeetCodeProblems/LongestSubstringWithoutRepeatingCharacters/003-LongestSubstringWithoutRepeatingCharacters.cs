namespace LeetCodeProblems.LongestSubstringWithoutRepeatingCharacters;

public static class _003_LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        var substring = new HashSet<char>();
        var maxLength = 0;
        var start = 0;

        foreach (var currentChar in s)
        {
            if (substring.Add(currentChar))
            {
                maxLength = Math.Max(maxLength, substring.Count);
            }
            else
            {
                while (substring.Contains(currentChar))
                {
                    substring.Remove(s[start]);
                    start++;
                }

                substring.Add(currentChar);
            }
        }

        return maxLength;
    }
}
