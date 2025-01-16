using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class LongestValidParenthesesTests
{
    [Theory]
    [InlineData("(()", 2)]
    [InlineData(")()())", 4)]
    [InlineData("", 0)]
    [InlineData("()(()", 2)]
    [InlineData("()(())", 6)]
    public void LongestValidParentheses_ValidInputs_ReturnsExpectedResult(string s, int expected)
    {
        // Arrange
        var solution = new _32_LongestValidParentheses();

        // Act
        var result = solution.LongestValidParentheses(s);

        // Assert
        Assert.Equal(expected, result);
    }
}