using LeetCodeProblems.FirstMissingPositive;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class FirstMissingPositiveTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 0 }, 3)]
    [InlineData(new[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new[] { 7, 8, 9, 11, 12 }, 1)]
    [InlineData(new[] { 1, 1 }, 2)]
    [InlineData(new[] { 2, 1 }, 3)]
    public void FirstMissingPositive_ValidInputs_ReturnsExpectedResult(int[] nums, int expected)
    {
        // Arrange
        var solution = new _41_FirstMissingPositive();

        // Act
        var result = solution.FirstMissingPositive(nums);

        // Assert
        Assert.Equal(expected, result);
    }
}