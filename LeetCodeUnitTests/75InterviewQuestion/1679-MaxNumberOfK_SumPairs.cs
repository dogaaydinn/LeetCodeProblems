using _75InterviewQuestion.MaxNumberOfK_SumPairs;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class MaxNumberOfK_SumPairsTests
{
    [Fact]
    public void MaxOperations_ValidInput_ReturnsCorrectNumberOfOperations()
    {
        // Arrange
        var solution = new _1679_MaxNumberOfK_SumPairs();
        int[] nums = { 1, 2, 3, 4 };
        var k = 5;
        var expected = 2;

        // Act
        var result = solution.MaxOperations(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxOperations_NoPairs_ReturnsZero()
    {
        // Arrange
        var solution = new _1679_MaxNumberOfK_SumPairs();
        int[] nums = { 1, 1, 1, 1 };
        var k = 5;
        var expected = 0;

        // Act
        var result = solution.MaxOperations(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxOperations_SinglePair_ReturnsOne()
    {
        // Arrange
        var solution = new _1679_MaxNumberOfK_SumPairs();
        int[] nums = { 3, 1, 3, 4, 3 };
        var k = 6;
        var expected = 1;

        // Act
        var result = solution.MaxOperations(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MaxOperations_EmptyArray_ReturnsZero()
    {
        // Arrange
        var solution = new _1679_MaxNumberOfK_SumPairs();
        int[] nums = { };
        var k = 5;
        var expected = 0;

        // Act
        var result = solution.MaxOperations(nums, k);

        // Assert
        Assert.Equal(expected, result);
    }
}