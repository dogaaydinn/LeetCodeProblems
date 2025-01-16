using LeetCodeProblems.RegularExpressionMatching;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class RegularExpressionMatchingTests
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    [InlineData("aab", "c*a*b", true)]
    [InlineData("mississippi", "mis*is*p*.", false)]
    public void IsMatch_ValidInputs_ReturnsExpectedResult(string s, string p, bool expected)
    {
        // Arrange
        var solution = new _10_RegularExpressionMatching();

        // Act
        var result = solution.IsMatch(s, p);

        // Assert
        Assert.Equal(expected, result);
    }
}