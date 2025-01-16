using _75InterviewQuestion.IncreasingTripletSubsequence;
using Xunit;

namespace LeetCodeTests._75InterviewQuestion;

public class IncreasingTripletSubsequenceTests
{
    [Fact]
    public void IncreasingTriplet_ValidTriplet_ReturnsTrue()
    {
        // Arrange
        var solution = new _334_IncreasingTripletSubsequence();
        int[] nums = { 1, 2, 3, 4, 5 };

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IncreasingTriplet_NoTriplet_ReturnsFalse()
    {
        // Arrange
        var solution = new _334_IncreasingTripletSubsequence();
        int[] nums = { 5, 4, 3, 2, 1 };

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IncreasingTriplet_TripletWithGaps_ReturnsTrue()
    {
        // Arrange
        var solution = new _334_IncreasingTripletSubsequence();
        int[] nums = { 2, 1, 5, 0, 4, 6 };

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IncreasingTriplet_EmptyArray_ReturnsFalse()
    {
        // Arrange
        var solution = new _334_IncreasingTripletSubsequence();
        int[] nums = { };

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void IncreasingTriplet_SingleElement_ReturnsFalse()
    {
        // Arrange
        var solution = new _334_IncreasingTripletSubsequence();
        int[] nums = { 1 };

        // Act
        var result = solution.IncreasingTriplet(nums);

        // Assert
        Assert.False(result);
    }
}