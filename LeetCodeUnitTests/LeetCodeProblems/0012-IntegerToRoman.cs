using LeetCodeProblems.IntegerToRoman;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class IntegerToRomanTests
{
    [Theory]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(9, "IX")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void IntToRoman_ValidInputs_ReturnsExpectedResult(int num, string expected)
    {
        // Arrange
        var solution = new _12_IntegerToRoman();

        // Act
        var result = solution.IntToRoman(num);

        // Assert
        Assert.Equal(expected, result);
    }
}