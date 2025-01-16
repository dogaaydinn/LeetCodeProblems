using LeetCodeProblems.RomanToInteger;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ValidInputs_ReturnsExpectedResult(string input, int expected)
    {
        // Arrange
        var solution = new _13_RomanToInteger();

        // Act
        var result = solution.RomanToInt(input);

        // Assert
        Assert.Equal(expected, result);
    }
}