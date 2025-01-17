namespace LeetCodeProblems.LongestSubstringWithoutRepeatingCharacters;

public class _0003_LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;
        int start = 0;
        var charIndexMap = new Dictionary<char, int>();

        for (int end = 0; end < s.Length; end++)
        {
            if (charIndexMap.ContainsKey(s[end]))
            {
                start = Math.Max(start, charIndexMap[s[end]] + 1);
            }

            charIndexMap[s[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}