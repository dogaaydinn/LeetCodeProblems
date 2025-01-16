using LeetCodeProblems.SearchInsertPosition;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class SearchInsertPositionTests
{
    [Theory]
    [InlineData(new[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new[] { 1, 3, 5, 6 }, 7, 4)]
    [InlineData(new[] { 1, 3, 5, 6 }, 0, 0)]
    [InlineData(new[] { 1 }, 0, 0)]
    public void SearchInsert_ValidInputs_ReturnsExpectedResult(int[] nums, int target, int expected)
    {
        // Arrange
        var solution = new _35_SearchInsertPosition();

        // Act
        var result = solution.SearchInsert(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}