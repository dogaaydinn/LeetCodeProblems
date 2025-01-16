using LeetCodeProblems.SearchInRotatedSortedArray;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SearchInRotatedSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
    [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    [InlineData(new[] { 1 }, 0, -1)]
    [InlineData(new[] { 1, 3 }, 3, 1)]
    [InlineData(new[] { 5, 1, 3 }, 5, 0)]
    public void Search_ValidInputs_ReturnsExpectedResult(int[] nums, int target, int expected)
    {
        // Arrange
        var solution = new _33_SearchInRotatedSortedArray();

        // Act
        var result = solution.Search(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}