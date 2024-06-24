namespace LeetCodeProblems.LongestSubstringWithoutRepeatingCharacters;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> substring = new HashSet<char>();
        var maxLength = 0;
        var start = 0;

        foreach (var currentChar in s)
        {
            if (!substring.Contains(currentChar))
            {
                substring.Add(currentChar);
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
