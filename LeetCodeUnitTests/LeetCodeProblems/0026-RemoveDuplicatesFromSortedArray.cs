using LeetCodeProblems.RemoveDuplicatesFromSortedArray;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Theory]
    [InlineData(new[] { 1, 1, 2 }, 2, new[] { 1, 2 })]
    [InlineData(new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new[] { 0, 1, 2, 3, 4 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, 1, new[] { 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new int[] { }, 0, new int[] { })]
    public void RemoveDuplicates_ValidInputs_ReturnsExpectedResult(int[] nums, int expectedLength, int[] expectedNums)
    {
        // Arrange
        var solution = new _26_RemoveDuplicatesFromSortedArray();

        // Act
        var resultLength = solution.RemoveDuplicates(nums);

        // Assert
        Assert.Equal(expectedLength, resultLength);
        for (var i = 0; i < expectedLength; i++) Assert.Equal(expectedNums[i], nums[i]);
    }
}