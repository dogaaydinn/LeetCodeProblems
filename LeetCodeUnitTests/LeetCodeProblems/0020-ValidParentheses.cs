using LeetCodeProblems.ValidParentheses;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ValidParenthesesTests
{
    [Theory]
    [InlineData("()", true)]
    [InlineData("()[]{}", true)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    [InlineData("", true)]
    public void IsValid_ValidInputs_ReturnsExpectedResult(string s, bool expected)
    {
        // Arrange
        var solution = new _20_ValidParentheses();

        // Act
        var result = solution.IsValid(s);

        // Assert
        Assert.Equal(expected, result);
    }
}