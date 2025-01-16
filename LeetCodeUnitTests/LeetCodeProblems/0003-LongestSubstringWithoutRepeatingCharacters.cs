using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class _003_LongestSubstringWithoutRepeatingCharactersTests
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("", 0)]
    [InlineData("au", 2)]
    [InlineData("dvdf", 3)]
    public void LengthOfLongestSubstring_ValidInputs_ReturnsExpectedResult(string s, int expected)
    {
        // Act
        var result = _003_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);

        // Assert
        Assert.Equal(expected, result);
    }
}