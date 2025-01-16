using LeetCodeProblems.TrappingRainWater;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class TrappingRainWaterTests
{
    [Theory]
    [InlineData(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6)]
    [InlineData(new[] { 4, 2, 0, 3, 2, 5 }, 9)]
    [InlineData(new[] { 1, 0, 2, 1, 0, 1, 3 }, 5)]
    [InlineData(new[] { 2, 0, 2 }, 2)]
    [InlineData(new[] { 3, 0, 0, 2, 0, 4 }, 10)]
    public void Trap_ValidInputs_ReturnsExpectedResult(int[] height, int expected)
    {
        // Arrange
        var solution = new _42_TrappingRainWater();

        // Act
        var result = solution.Trap(height);

        // Assert
        Assert.Equal(expected, result);
    }
}