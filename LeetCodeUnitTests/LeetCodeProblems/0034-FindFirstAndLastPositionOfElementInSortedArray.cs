using LeetCodeProblems.FindFirstAndLastPositionOfElementInSortedArray;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class FindFirstAndLastPositionOfElementInSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
    [InlineData(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
    [InlineData(new int[] { }, 0, new[] { -1, -1 })]
    [InlineData(new[] { 1 }, 1, new[] { 0, 0 })]
    [InlineData(new[] { 2, 2 }, 2, new[] { 0, 1 })]
    public void SearchRange_ValidInputs_ReturnsExpectedResult(int[] nums, int target, int[] expected)
    {
        // Arrange
        var solution = new _34_FindFirstAndLastPositionOfElementInSortedArray();

        // Act
        var result = solution.SearchRange(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}