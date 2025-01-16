using LeetCodeProblems.WildcardMatching;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class WildcardMatchingTests
{
    [Theory]
    [InlineData("adceb", "*a*b", true)] // Example from the problem
    [InlineData("aa", "a", false)] // Mismatch: 'a' doesn't match 'aa'
    [InlineData("aa", "*", true)] // '*' matches everything
    [InlineData("cb", "?a", false)] // '?' matches 'c', but 'a' doesn't match 'b'
    [InlineData("adceb", "a*b", true)] // '*' matches "dce"
    [InlineData("", "*", true)] // '*' matches empty string
    [InlineData("", "?", false)] // '?' cannot match empty string
    [InlineData("abcd", "****", true)] // Multiple '*' treated as a single '*'
    public void IsMatch_ValidInputs_ReturnsExpectedResult(string s, string p, bool expected)
    {
        // Arrange
        var solution = new _44_WildcardMatching();

        // Act
        var result = solution.IsMatch(s, p);

        // Assert
        Assert.Equal(expected, result);
    }
}