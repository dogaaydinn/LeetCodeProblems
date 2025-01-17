namespace LeetCodeProblems.LongestPalindromicSubstring;

public class _0005_LongestPalindromicSubstring
{
    public static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return "";
        }

        int start = 0, maxLength = 1;

        for (var i = 0; i < s.Length; i++)
        {
            // Odd length palindromes
            int low = i, high = i;
            while (low >= 0 && high < s.Length && s[low] == s[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                low--;
                high++;
            }

            // Even length palindromes
            low = i;
            high = i + 1;
            while (low >= 0 && high < s.Length && s[low] == s[high])
            {
                if (high - low + 1 > maxLength)
                {
                    start = low;
                    maxLength = high - low + 1;
                }
                low--;
                high++;
            }
        }

        return s.Substring(start, maxLength);
    }
}