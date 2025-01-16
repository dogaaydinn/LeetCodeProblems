using LeetCodeProblems.ReverseInteger;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ReverseIntegerTests
{
    [Theory]
    [InlineData(123, 321)]
    [InlineData(-123, -321)]
    [InlineData(120, 21)]
    [InlineData(0, 0)]
    [InlineData(1534236469, 0)] // Overflow case
    public void Reverse_ValidInputs_ReturnsExpectedResult(int input, int expected)
    {
        // Act
        var result = _007_ReverseInteger.Reverse(input);

        // Assert
        Assert.Equal(expected, result);
    }
}