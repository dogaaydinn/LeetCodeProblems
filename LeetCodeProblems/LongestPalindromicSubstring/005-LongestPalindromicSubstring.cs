namespace LeetCodeProblems.LongestPalindromicSubstring;

public static class _005_LongestPalindromicSubstring
{
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
