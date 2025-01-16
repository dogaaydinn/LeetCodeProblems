using LeetCodeProblems.GenerateParentheses;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class GenerateParenthesesTests
{
    [Theory]
    [InlineData(1, new[] { "()" })]
    [InlineData(2, new[] { "(())", "()()" })]
    [InlineData(3, new[] { "((()))", "(()())", "(())()", "()(())", "()()()" })]
    public void GenerateParenthesis_ValidInputs_ReturnsExpectedResult(int n, string[] expected)
    {
        // Arrange
        var solution = new _22_GenerateParentheses();

        // Act
        var result = solution.GenerateParenthesis(n);

        // Assert
        Assert.Equal(expected, result);
    }
}