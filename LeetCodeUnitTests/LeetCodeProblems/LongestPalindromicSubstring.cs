using LeetCodeProblems.LongestPalindromicSubstring;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestPalindromicSubstring
{
    [Fact]
    public void LongestPalindrome_ReturnsCorrectSubstring()
    {
        const string input = "babad";
        
        var result = _005_LongestPalindromicSubstring.LongestPalindrome(input);
        
        Assert.Contains(result, new[] { "bab", "aba" });
    }
}