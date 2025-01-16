using LeetCodeProblems.MultiplyStrings;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class MultiplyStringsTests
{
    [Theory]
    [InlineData("2", "3", "6")]
    [InlineData("123", "456", "56088")]
    [InlineData("0", "0", "0")]
    [InlineData("999", "999", "998001")]
    [InlineData("123456789", "987654321", "121932631112635269")]
    public void Multiply_ValidInputs_ReturnsExpectedResult(string num1, string num2, string expected)
    {
        // Arrange
        var solution = new _43_MultiplyStrings();

        // Act
        var result = solution.Multiply(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
}