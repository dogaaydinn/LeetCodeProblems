using LeetCodeProblems.Next_Permutation;
using Xunit;

namespace LeetCodeTests.LeetCodeProblems;

public class NextPermutationTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3 }, new[] { 1, 3, 2 })]
    [InlineData(new[] { 3, 2, 1 }, new[] { 1, 2, 3 })]
    [InlineData(new[] { 1, 1, 5 }, new[] { 1, 5, 1 })]
    [InlineData(new[] { 1, 3, 2 }, new[] { 2, 1, 3 })]
    public void NextPermutation_ValidInputs_ReturnsExpectedResult(int[] nums, int[] expected)
    {
        // Arrange
        var solution = new _31_Next_Permutation();

        // Act
        solution.NextPermutation(nums);

        // Assert
        Assert.Equal(expected, nums);
    }
}