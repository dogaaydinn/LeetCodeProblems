using LeetCodeProblems.LongestPalindromicSubstring;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestPalindromicSubstringTests
{
    [Theory]
    [InlineData("babad", "bab")]
    [InlineData("cbbd", "bb")]
    [InlineData("a", "a")]
    [InlineData("ac", "a")]
    [InlineData("racecar", "racecar")]
    public void LongestPalindrome_ValidInputs_ReturnsExpectedResult(string s, string expected)
    {
        // Act
        var result = _005_LongestPalindromicSubstring.LongestPalindrome(s);

        // Assert
        Assert.Equal(expected, result);
    }
}