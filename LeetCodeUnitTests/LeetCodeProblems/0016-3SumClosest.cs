using LeetCodeProblems._3SumClosest;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class ThreeSumClosestTests
{
    [Theory]
    [InlineData(new[] { -1, 2, 1, -4 }, 1, 2)] // Closest to 1 is -1 + 2 + 1 = 2
    [InlineData(new[] { 0, 0, 0 }, 1, 0)] // Closest to 1 is 0 + 0 + 0 = 0
    [InlineData(new[] { 1, 1, 1, 1 }, 3, 3)] // Closest to 3 is 1 + 1 + 1 = 3
    [InlineData(new[] { -3, -2, -5, 3, -4 }, -1, -2)] // Closest to -1 is -3 + 3 + -2 = -2
    [InlineData(new[] { 1, 1, -1, -1, 3 }, 3, 3)] // Closest to 3 is 1 + 1 + 1 = 3
    public void ThreeSumClosest_ValidInputs_ReturnsExpectedResult(int[] nums, int target, int expected)
    {
        // Arrange
        var solution = new _16_3SumClosest();

        // Act
        var result = solution.ThreeSumClosest(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}