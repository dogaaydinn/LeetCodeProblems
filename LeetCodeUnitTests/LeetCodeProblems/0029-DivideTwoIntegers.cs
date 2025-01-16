using LeetCodeProblems.DivideTwoIntegers;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class DivideTwoIntegersTests
{
    [Theory]
    [InlineData(10, 3, 3)]
    [InlineData(7, -3, -2)]
    [InlineData(0, 1, 0)]
    [InlineData(1, 1, 1)]
    [InlineData(-2147483648, -1, 2147483647)] // int.MinValue / -1 should return int.MaxValue
    public void Divide_ValidInputs_ReturnsExpectedResult(int dividend, int divisor, int expected)
    {
        // Arrange
        var solution = new _29_DivideTwoIntegers();

        // Act
        var result = solution.Divide(dividend, divisor);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var solution = new _29_DivideTwoIntegers();

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => solution.Divide(1, 0));
    }
}