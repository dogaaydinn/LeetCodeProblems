using LeetCodeProblems.RemoveElement;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new[] { 3, 2, 2, 3 }, 3, 2, new[] { 2, 2 })]
    [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new[] { 0, 1, 3, 0, 4 })]
    [InlineData(new[] { 1 }, 1, 0, new int[] { })]
    [InlineData(new[] { 4, 5 }, 5, 1, new[] { 4 })]
    [InlineData(new int[] { }, 0, 0, new int[] { })]
    public void RemoveElement_ValidInputs_ReturnsExpectedResult(int[] nums, int val, int expectedLength,
        int[] expectedNums)
    {
        // Arrange
        var solution = new _27_RemoveElement();

        // Act
        var resultLength = solution.RemoveElement(nums, val);

        // Assert
        Assert.Equal(expectedLength, resultLength);
        for (var i = 0; i < expectedLength; i++) Assert.Equal(expectedNums[i], nums[i]);
    }
}